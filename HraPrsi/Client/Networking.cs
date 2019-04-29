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
        public static string sessionName;
        public static PrsiService.AppState appState;
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

            Networking.sessionName = service.RegisterSession(playerName);
            Networking.appState = service.GetState(Networking.sessionName);

            SetNetworkStateTimer();

            Console.WriteLine("SESSION CODE: " + Networking.sessionName + ", SHARE THIS WITH YOUR FRIENDS!");
        }

        public void JoinSession (string sessionName, string playerName)
        {
            Networking.sessionName = sessionName;

            service.JoinSession(Networking.sessionName, playerName);

            if (Networking.appState != null)
            {
                myName = playerName;
                Console.WriteLine("Connected to session: " + Networking.sessionName);
                SetNetworkStateTimer();
            } 
        }

        public void LoadState ()
        {
            Networking.appState = service.GetState(Networking.sessionName);
            Console.WriteLine("=== APP STATE ===");
            Console.WriteLine("game started: " + Networking.appState.gameStarted);
            Console.WriteLine("players: ");
            foreach (Player player in Networking.appState.players)
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
            Networking.appState = service.GetState(sessionName);

            if (Networking.appState.players != lastAppState.players)
            {
                OnPlayersChanged(appState.players);
            }

            if (Networking.appState.gameStarted != lastAppState.gameStarted)
            {
                OnGameStateChanged(Networking.appState.gameStarted);
            }

            if (Networking.appState.playerTurn != lastAppState.playerTurn)
            {
                Player player = Networking.appState.players.ElementAt(Networking.appState.playerTurn);
                OnTurnChanged(player, Networking.appState.playerTurn);
            }

            lastAppState = Networking.appState;
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
            service.PlayCard(Networking.sessionName, myName, card);
        }

        // zavolat, když chci přeskočit můj tah
        private void SkipTurn ()
        {
            service.SkipTurn(Networking.sessionName, myName);
        }
    }
}
