using Server.Common;
using Server.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Server
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]
        public string RegisterSession (string playerName)
        {
            string sessionName = RandomString.Generate(5);
            AppState appState = CreateState(sessionName);
            AddPlayer(appState, playerName, true);

            return sessionName;
        }

        [WebMethod]
        public void JoinSession (string sessionName, string playerName)
        {
            AppState appState = GetState(sessionName);
            AddPlayer(appState, playerName, false);
        }

        public void LeaveSession (string sessionName, string playerName)
        {
            AppState appState = GetState(sessionName);
            RemovePlayer(appState, playerName);
        }

        private void AddPlayer(AppState appState, string playerName, bool isCreator)
        {
            Player newPlayer = new Player();
            newPlayer.SetName(playerName);
            newPlayer.SetCreator(isCreator);
            appState.players.Add(newPlayer);
        }

        private void RemovePlayer(AppState appState, string playerName)
        {
            Player player = appState.players.Find(p => p.name == playerName);
            appState.players.Remove(player);
        }

        private AppState CreateState(string sessionName)
        {
            Application[sessionName] = new AppState();
            return (AppState)Application[sessionName];
        }

        [WebMethod]
        public AppState GetState (string sessionName)
        {
            return (AppState)Application[sessionName];
        }

        private bool SaveState (AppState appState, string sessionName)
        {
            Application[sessionName] = appState;

            if (Application[sessionName] != null) return true;
            else return false;
        }

        [WebMethod]
        public void StartGame (string sessionName, string playerName)
        {
            AppState appState = GetState(sessionName);

            Player player = appState.players.Find(p => p.name == playerName);

            if (player.isCreator)
                appState.gameStarted = true;

            SaveState(appState, sessionName);
        }
        
    }
}
