using Client.PrsiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Client.Networking
{
    class Networking
    {
        public string sessionName { get; private set; }
        private PrsiService.AppState appState;
        private PrsiService.AppState lastAppState;

        private PrsiService.WebServiceSoapClient service;
        private Timer netSyncTimer;

        private string myName;

        public Networking ()
        {
            service = new PrsiService.WebServiceSoapClient();
        }

        public void CreateSession (string playerName)
        {
            myName = playerName;

            sessionName = service.RegisterSession(playerName);
            appState = service.GetState(sessionName);

            SetNetworkStateTimer();

            Console.WriteLine("SESSION CODE: " + sessionName + ", SHARE THIS WITH YOUR FRIENDS!");
        }

        public void JoinSession (string sessionName, string playerName)
        {
            sessionName = sessionName;

            service.JoinSession(sessionName, playerName);

            if (appState != null)
            {
                myName = playerName;
                Console.WriteLine("Connected to session: " + sessionName);
                SetNetworkStateTimer();
            } 
        }

        public void LoadState ()
        {
            appState = service.GetState(sessionName);
            Console.WriteLine("=== APP STATE ===");
            Console.WriteLine("game started: " + appState.gameStarted);
            Console.WriteLine("players: ");
            foreach (Player player in appState.players)
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
            appState = service.GetState(sessionName);

            if (appState.players != lastAppState.players)
            {
                OnPlayersChanged(appState.players);
            }

            if (appState.gameStarted != lastAppState.gameStarted)
            {
                OnGameStateChanged(appState.gameStarted);
            }

            if (appState.playerTurn != lastAppState.playerTurn)
            {
                Player player = appState.players.ElementAt(appState.playerTurn);
                OnTurnChanged(player, appState.playerTurn);
            }

            lastAppState = appState;
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
            if (player.order == playerIndex && player.name == myName)
            {
                Console.WriteLine("My turn");
            }

            // update list of players (GUI)
        }

        /* zavolat, když chci hrát kartu
         * sessionManager.PlayCard(SessionManager.appState.cardStack.ElementAt(3)); - z GUI.cs
        */
        private void PlayCard (Card card)
        {
            service.PlayCard(sessionName, myName, card);
        }

        // zavolat, když chci přeskočit můj tah
        private void SkipTurn ()
        {
            service.SkipTurn(sessionName, myName);
        }
    }
}
