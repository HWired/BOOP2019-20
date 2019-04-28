using Client.PrsiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Client.Networking
{
    class SessionManager
    {
        public static string sessionName;
        public static PrsiService.AppState appState;
        private PrsiService.AppState lastAppState;

        private PrsiService.WebServiceSoapClient service;
        private Timer netSyncTimer;

        public SessionManager ()
        {
            service = new PrsiService.WebServiceSoapClient();
        }

        public void CreateSession (string playerName)
        {
            SessionManager.sessionName = service.RegisterSession(playerName);
            SessionManager.appState = service.GetState(SessionManager.sessionName);

            SetNetworkStateTimer();

            Console.WriteLine("SESSION CODE: " + SessionManager.sessionName + ", SHARE THIS WITH YOUR FRIENDS!");
        }

        public void JoinSession (string sessionName, string playerName)
        {
            SessionManager.sessionName = sessionName;

            service.JoinSession(SessionManager.sessionName, playerName);

            if (SessionManager.appState != null)
            {
                Console.WriteLine("Connected to session: " + SessionManager.sessionName);
                SetNetworkStateTimer();
            } 
        }

        public void LoadState ()
        {
            SessionManager.appState = service.GetState(SessionManager.sessionName);
            Console.WriteLine("=== APP STATE ===");
            Console.WriteLine("game started: " + SessionManager.appState.gameStarted);
            Console.WriteLine("players: ");
            foreach (Player player in SessionManager.appState.players)
            {
                Console.WriteLine("Player: " + player.name + ", isCreator: " + player.isCreator);
            }
        }

        private void SetNetworkStateTimer()
        {
            netSyncTimer = new Timer(1000);
            netSyncTimer.Elapsed += CheckNetState;
            netSyncTimer.AutoReset = true;
            netSyncTimer.Enabled = true;
        }

        private void CheckNetState(Object source, ElapsedEventArgs e)
        {
            SessionManager.appState = service.GetState(sessionName);

            if (SessionManager.appState.players != lastAppState.players)
            {
                OnPlayersChanged(appState.players);
            }

            if (SessionManager.appState.gameStarted != lastAppState.gameStarted)
            {
                OnGameStateChanged(SessionManager.appState.gameStarted);
            }

            if (SessionManager.appState.playerTurn != lastAppState.playerTurn)
            {
                Player player = SessionManager.appState.players.ElementAt(SessionManager.appState.playerTurn);
                OnTurnChanged(player, SessionManager.appState.playerTurn);
            }

            lastAppState = SessionManager.appState;
        }

        // voláno při změně počtu hráčů tj. někdo přišel / odešel
        private void OnPlayersChanged (Player[] players)
        {
            Console.WriteLine("Someone joined or leaved");

            // update list of players (GUI)
        }

        // voláno při změně stavu hry (na začátku a na konci hry)
        private void OnGameStateChanged (bool gameStarted)
        {
            if (gameStarted)
            {
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
            if (player.order == playerIndex)
            {
                Console.WriteLine("My turn");
            }

            // update list of players (GUI)
        }
    }
}
