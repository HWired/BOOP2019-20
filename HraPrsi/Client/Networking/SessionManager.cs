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
            // Hook up the Elapsed event for the timer. 
            netSyncTimer.Elapsed += CheckNetState;
            netSyncTimer.AutoReset = true;
            netSyncTimer.Enabled = true;
        }

        private void CheckNetState(Object source, ElapsedEventArgs e)
        {
            SessionManager.appState = service.GetState(sessionName);

            if (SessionManager.appState.players != lastAppState.players)
            {
                OnPlayerCntChange(appState.players);
            }

            if (SessionManager.appState.gameStarted != lastAppState.gameStarted)
            {
                OnGameStateChanged(SessionManager.appState.gameStarted);
            }

            if (SessionManager.appState.playerTurn != lastAppState.playerTurn)
            {
                OnTurnChanged();
            }

            lastAppState = SessionManager.appState;
        }

        // voláno při změně počtu hráčů
        private void OnPlayerCntChange (PrsiService.Player[] players)
        {

        }

        // voláno při změně stavu hry (na začátku a na konci hry)
        private void OnGameStateChanged (bool gameStarted)
        {

        }

        // voláno potom co někdo táhne/přeskočí kartu
        private void OnTurnChanged ()
        {

        }
    }
}
