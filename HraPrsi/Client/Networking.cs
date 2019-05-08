using Client.PrsiService;
using System;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace Client
{
    public class Networking
    {
        public string sessionName { get; private set; }
        private int playerID;

        private AppState appState;
        private AppState lastAppState;

        private PrsiService.WebServiceSoapClient service;
        private System.Timers.Timer netSyncTimer;

        public StartingGUI startingGUI;
        public GameGUI gameGUI;

        public Networking ()
        {
            service = new PrsiService.WebServiceSoapClient();
        }

        public void CreateSession (string playerName)
        {
            RegisterSessionInfo registerSessionInfo = service.RegisterSession(playerName);
            sessionName = registerSessionInfo.sessionName;
            playerID = registerSessionInfo.playerID;

            appState = service.GetState(sessionName);
            lastAppState = appState;
            SetNetworkStateTimer();

            Console.WriteLine($"SESSION CODE: {sessionName}, SHARE THIS WITH YOUR FRIENDS! (id: {this.playerID})");
        }

        public void JoinSession (string sessionName, string playerName)
        {
            this.sessionName = sessionName;
            playerID = service.JoinSession(sessionName, playerName);

            appState = service.GetState(sessionName);
            lastAppState = appState;
            if (appState != null)
            {
                Console.WriteLine($"Connected to session: {sessionName} (id: {this.playerID})");
                SetNetworkStateTimer();
            }
        }

        private void SetNetworkStateTimer()
        {
            netSyncTimer = new System.Timers.Timer(1000);
            netSyncTimer.Elapsed += CheckNetState;
            netSyncTimer.AutoReset = true;
            netSyncTimer.Enabled = true;
        }

        private void CheckNetState(Object source, ElapsedEventArgs e)
        {
            appState = service.GetState(sessionName);

            if(!PlayersUpdated(lastAppState.players, appState.players))
            {
                OnPlayersChanged(appState.players);
                lastAppState.players = appState.players;
            }

            if (appState.gameStarted != lastAppState.gameStarted)
            {
                OnGameStateChanged(appState.gameStarted);
                lastAppState.gameStarted = appState.gameStarted;
            }

            if (appState.playerTurn != lastAppState.playerTurn)
            {
                Player player = appState.players.ElementAt(appState.playerTurn);
                OnTurnChanged(player, appState.playerTurn);
            }

            lastAppState = appState;
        }

        private bool PlayersUpdated (Player[] lastPlayers, Player[] players)
        {
            if (lastPlayers.Length != players.Length)
                return false;

            for (int p = 0; p < players.Length; p++)
            {
                if (players[p].id != lastPlayers[p].id)
                    return false;
            }

            return true;
        }

        private Player GetMyPlayer (Player[] players)
        {
            for (int p = 0; p < players.Length; p++)
            {
                if (players[p].id == this.playerID)
                    return players[p];
            }

            return null;
        }

        public void OnGameWindowReady ()
        {
            OnPlayersChanged(appState.players);
        }

        private void OnPlayersChanged (Player[] players)
        {
            Console.WriteLine("Someone joined the room.");
            gameGUI.UpdatePlayerListInvoke(players, appState.playerTurn, GetMyPlayer(appState.players));
        }

        private void OnGameStateChanged (bool gameStarted)
        {
            if (gameStarted)
            {
                gameGUI.OnGameStart();
                gameGUI.UpdatePlayedCard(appState.cardPlayed);
                gameGUI.UpdatePlayerCards(GetMyPlayer(appState.players).cards);
                Console.WriteLine("Game just started");
            }
            else
            {
                if (gameGUI.InvokeRequired) gameGUI.Invoke(new MethodInvoker(delegate { gameGUI.Close(); }));
                else gameGUI.Close();

                netSyncTimer.Stop();
                MessageBox.Show("Winner: " + appState.winner);
            }
        }

        private void OnTurnChanged (Player player, int playerIndex)
        {
            gameGUI.UpdatePlayedCard(appState.cardPlayed);
            gameGUI.UpdatePlayerCards(GetMyPlayer(appState.players).cards);
            gameGUI.UpdatePlayerListInvoke(appState.players, appState.playerTurn, GetMyPlayer(appState.players));

            if (player.id == appState.players.ElementAt(playerIndex).id && player.id == this.playerID)
            {
                Console.WriteLine($"My turn: {player.name}");
            } else
            {
                Console.WriteLine($"Player turn: {player.name}");
            }
        }

        public void StartGame ()
        {
            service.StartGame(sessionName, this.playerID);
        }

        public void LeaveRoom ()
        {
            service.LeaveSession(sessionName, this.playerID);
        }

        public void PlayCard (Card card)
        {
            service.PlayCard(sessionName, this.playerID, card);
        }

        public void SkipTurn ()
        {
            service.SkipTurn(sessionName, this.playerID);
        }
    }
}
