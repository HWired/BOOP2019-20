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
            Console.WriteLine("# CARDS: ");
            foreach (Card card in appState.cardStack)
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

        public void OnGameReady ()
        {
            OnPlayersChanged(appState.players);
        }

        // voláno při změně počtu hráčů tj. někdo přišel / odešel
        private void OnPlayersChanged (Player[] players)
        {
            Console.WriteLine("Someone joined or leaved");
            gameGUI.UpdatePlayerListInvoke(players);
            // update list of players (GUI)
        }

        // voláno při změně stavu hry (na začátku a na konci hry)
        private void OnGameStateChanged (bool gameStarted)
        {
            if (gameStarted)
            {
                gameGUI.OnGameStart();
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
            Console.WriteLine(player.name);
            if (player.id == playerIndex && player.id == this.playerID)
            {
                Console.WriteLine("My turn");
            }

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
        private void PlayCard (Card card)
        {
            //service.PlayCard(sessionName, myName, card);
        }

        // zavolat, když chci přeskočit můj tah
        private void SkipTurn ()
        {
            //service.SkipTurn(sessionName, myName);
        }
    }
}
