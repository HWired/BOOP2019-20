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

        public void CreateSession ()
        {
            SessionManager.sessionName = client.RegisterSession();
            SessionManager.appState = client.GetState(SessionManager.sessionName);

            Console.WriteLine("SESSION CODE: " + SessionManager.sessionName + ", SHARE THIS WITH YOUR FRIENDS!");
        }

        public void JoinSession (string sessionName)
        {
            SessionManager.sessionName = sessionName;
            SessionManager.appState = client.GetState(SessionManager.sessionName);

            if (SessionManager.appState != null)
                Console.WriteLine("Connected to session: " + SessionManager.sessionName);
        }

        public void LoadState ()
        {
            SessionManager.appState = client.GetState(SessionManager.sessionName);
            Console.WriteLine("=== APP STATE ===");
            Console.WriteLine("integer: " + SessionManager.appState.integer);
            Console.WriteLine("str: " + SessionManager.appState.str);
        }

        public void SaveState()
        {
            SessionManager.appState.integer += 1000;
            SessionManager.appState.str += "str, ";
            Console.WriteLine(client.SaveState(SessionManager.appState, SessionManager.sessionName));
        }
    }
}
