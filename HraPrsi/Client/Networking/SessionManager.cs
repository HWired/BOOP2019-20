using Client.PrsiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Networking
{
    class SessionManager
    {
        public static string sessionName;
        public static PrsiService.AppState appState;

        private PrsiService.WebServiceSoapClient client;

        public SessionManager ()
        {
            client = new PrsiService.WebServiceSoapClient();
        }

        public void CreateSession (string playerName)
        {
            SessionManager.sessionName = client.RegisterSession(playerName);
            SessionManager.appState = client.GetState(SessionManager.sessionName);

            Console.WriteLine("SESSION CODE: " + SessionManager.sessionName + ", SHARE THIS WITH YOUR FRIENDS!");
        }

        public void JoinSession (string sessionName, string playerName)
        {
            SessionManager.sessionName = sessionName;

            client.JoinSession(SessionManager.sessionName, playerName);

            if (SessionManager.appState != null)
                Console.WriteLine("Connected to session: " + SessionManager.sessionName);
        }

        public void LoadState ()
        {
            SessionManager.appState = client.GetState(SessionManager.sessionName);
            Console.WriteLine("=== APP STATE ===");
            Console.WriteLine("game started: " + SessionManager.appState.gameStarted);
            Console.WriteLine("players: ");
            foreach (Player player in SessionManager.appState.players)
            {
                Console.WriteLine("Player: " + player.name + ", isCreator: " + player.isCreator);
            }
        }
    }
}
