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
        private AppState appState;
        private string sessionName;

        [WebMethod]
        public string RegisterSession (string playerName)
        {
            string sessionName = RandomString.Generate(5);
            CreateState(sessionName);

            LoadSession(sessionName);
            AddPlayer(playerName, true);
            SaveSession(sessionName);

            return sessionName;
        }

        [WebMethod]
        public void JoinSession (string sessionName, string playerName)
        {
            LoadSession(sessionName);

            AddPlayer(playerName, false);

            SaveSession(sessionName);
        }

        [WebMethod]
        public void LeaveSession (string sessionName, string playerName)
        {
            LoadSession(sessionName);

            RemovePlayer(playerName);

            SaveSession(sessionName);
        }

        private void AddPlayer(string playerName, bool isCreator)
        {
            Player newPlayer = new Player();

            newPlayer.SetName(playerName);
            newPlayer.SetCreator(isCreator);
            newPlayer.SetOrder(appState.players.Count);

            appState.players.Add(newPlayer);
        }

        private void RemovePlayer (string playerName)
        {
            Player player = appState.players.Find(p => p.name == playerName);
            appState.players.Remove(player);
        }

        [WebMethod]
        public void StartGame (string sessionName, string playerName)
        {
            LoadSession(sessionName);

            Player player = appState.players.Find(p => p.name == playerName);

            if (player.isCreator)
                appState.gameStarted = true;

            SaveSession(sessionName);
        }
        
        [WebMethod]
        public void PlayCard (string sessionName, string playerName, Card card)
        {
            LoadSession(sessionName);

            Player player = appState.players.Find(p => p.name == playerName);

            if (IsPlayersTurn(player))
            {
                if (CardCanBePlayed(player, card))
                {
                    if (CheckCardWithRules(card))
                    {
                        appState.topCardStackPlayed = card;
                        player.cards.Remove(card);
                        NextPlayer(sessionName);

                        SaveSession(sessionName);
                    }
                }
            }
        }

        private bool IsPlayersTurn (Player player)
        {
            if (appState.playerTurn % player.order == 0)
                return true;

            return false;
        }

        private bool CardCanBePlayed (Player player, Card card)
        {
            if (player.cards.Contains(card))
                return true;

            return false;
        }

        private bool CheckCardWithRules (Card card)
        {
            // Same color? Pass
            if (appState.topCardStackPlayed.color == card.color && card.value != CardValue.CA)
                return true;

            // Same value? Pass
            if (appState.topCardStackPlayed.value == card.value)
                return true;

            return false;
        }

        private void NextPlayer (string sessionName)
        {
            appState.playerTurn += 1;
            appState.playerTurn = appState.playerTurn % appState.players.Count;
        }

        [WebMethod]
        public void SkipTurn (string sessionName, string playerName)
        {
            LoadSession(sessionName);

            Player player = appState.players.Find(p => p.name == playerName);

            if (IsPlayersTurn(player))
            {
                appState.players.ElementAt(appState.playerTurn).cards.Add(appState.cardStack.ElementAt(0));
                appState.cardStack.RemoveAt(0);

                SaveSession(sessionName);
            }
        }

        private void LoadSession (string sessionName)
        {
            this.sessionName = sessionName;
            appState = GetState(sessionName);
        }

        private void CreateState (string sessionName)
        {
            Application[sessionName] = new AppState();
        }

        [WebMethod]
        public AppState GetState (string sessionName)
        {
            return (AppState)Application[sessionName];
        }

        private bool SaveSession (string sessionName)
        {
            Application[sessionName] = appState;

            if (Application[sessionName] != null) return true;
            else return false;
        }
    }
}
