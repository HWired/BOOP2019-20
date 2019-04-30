using Client.PrsiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void LoadState ()
        {
            appState = service.GetState(sessionName);

            Player me = GetMyPlayer(appState.players);

            Console.WriteLine($"MyPlayer name: {me.name}, isCreator: {me.isCreator}");

            Console.WriteLine("=== APP STATE ===");
            Console.WriteLine("game started: " + appState.gameStarted);
            Console.WriteLine("players: ");
            foreach (Player player in appState.players)
            {
                Console.WriteLine("Player: " + player.name + ", isCreator: " + player.isCreator);
            }

            Console.WriteLine($"Card on the table: {appState.cardPlayed.type}     {appState.cardPlayed.color}        {appState.cardPlayed.value}");

            Console.WriteLine("My cards");
            foreach (Card card in me.cards)
            {
                Console.WriteLine($"{card.type}     {card.color}        {card.value}");
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
            gameGUI.UpdatePlayerListInvoke(players);
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
                Console.WriteLine("Game just ended");
            }
        }

        // voláno potom co někdo táhne/přeskočí kartu
        private void OnTurnChanged (Player player, int playerIndex)
        {
            gameGUI.UpdatePlayedCard(appState.cardPlayed);
            gameGUI.UpdatePlayerCards(GetMyPlayer(appState.players).cards);

            if (player.id == appState.players.ElementAt(playerIndex).id && player.id == this.playerID)
            {
                Console.WriteLine($"My turn: {player.name}");
            } else
            {
                Console.WriteLine($"Player turn: {player.name}");
            }

            LoadState();

            // update list of players (GUI)
        }

        public void StartGame ()
        {
            service.StartGame(sessionName, this.playerID);
        }

        public void LeaveRoom ()
        {
            service.LeaveSession(sessionName, this.playerID);
        }

        /* zavolat, když chci hrát kartu
         * sessionManager.PlayCard(SessionManager.appState.cardStack.ElementAt(3)); - z GUI.cs
        */
        public void PlayCard (Card card)
        {
            service.PlayCard(sessionName, this.playerID, card);
        }

        // zavolat, když chci přeskočit můj tah
        public void SkipTurn ()
        {
            service.SkipTurn(sessionName, this.playerID);
        }
    }
}
