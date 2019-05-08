using Server.Common;
using Server.DataStructures;
using System.Collections.Generic;
using System.Linq;
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
        public RegisterSessionInfo RegisterSession (string playerName)
        {
            RegisterSessionInfo registerSessionInfo = new RegisterSessionInfo();
            string sessionName = RandomString.Generate(5);
            registerSessionInfo.sessionName = sessionName;

            CreateState(sessionName);
            registerSessionInfo.playerID = AddPlayer(playerName, true);
            GenerateCardDeck();
            SaveSession(sessionName);

            return registerSessionInfo;
        }

        private void GenerateCardDeck ()
        {
            RandomCardDeck randomCardDeck = new RandomCardDeck();
            appState.cardStack = randomCardDeck.GetCards();
        }

        [WebMethod]
        public int JoinSession (string sessionName, string playerName)
        {
            LoadSession(sessionName);
            int playerID = AddPlayer(playerName, false);
            SaveSession(sessionName);

            return playerID;
        }

        public int AddPlayer(string name, bool isCreator)
        {
            Player newPlayer = new Player();
            newPlayer.name = name;
            newPlayer.isCreator = isCreator;
            appState.AddPlayer(newPlayer);

            return newPlayer.id;
        }

        [WebMethod]
        public void LeaveSession (string sessionName, int playerID)
        {
            LoadSession(sessionName);
            RemovePlayer(playerID);
            SaveSession(sessionName);
        }

        private void RemovePlayer (int playerID)
        {
            Player player = appState.players.Find(p => p.id == playerID);
            appState.players.Remove(player);
        }

        [WebMethod]
        public void StartGame (string sessionName, int playerID)
        {
            LoadSession(sessionName);
            Player player = appState.players.Find(p => p.id == playerID);

            if (player.isCreator)
            {
                appState.StartGame();

                // add cards to each player
                foreach (Player playerIterator in appState.players)
                {
                    List<Card> selectedCards = appState.cardStack.GetRange(0, 4);
                    playerIterator.cards.AddRange(selectedCards);
                    appState.cardStack.RemoveRange(0, 4);
                }

                // turn 1 card on the table
                Card selectedCard = appState.cardStack.First();
                appState.SetPlayedCard(selectedCard);
                appState.cardStack.RemoveAt(0);
            }

            SaveSession(sessionName);
        }
        
        [WebMethod]
        public void PlayCard (string sessionName, int playerID, Card card)
        {
            LoadSession(sessionName);

            Player player = appState.players.Find(p => p.id == playerID);

            if (IsPlayersTurn(player))
            {
                if (CheckCardWithRules(card))
                {
                    if (!appState.nextPlayer7 && !appState.nextPlayerAce)
                    {
                        appState.SetPlayedCard(card);
                        RemoveCardFromPlayer(player, card);

                        if (card.value == CardValue.C7)
                            appState.nextPlayer7 = true;

                        if (card.value == CardValue.CA)
                            appState.nextPlayerAce = true;
                    }
                    else if (appState.nextPlayer7 && card.value == CardValue.C7)
                    {
                        appState.SetPlayedCard(card);
                        RemoveCardFromPlayer(player, card);
                        appState.nextPlayer7 = false;
                    }
                    else if (appState.nextPlayerAce && card.value == CardValue.CA)
                    {
                        appState.SetPlayedCard(card);
                        RemoveCardFromPlayer(player, card);
                        appState.nextPlayerAce = false;
                    }

                    if (IsWinner(player))
                    {
                        appState.winner = player.name;
                        appState.gameStarted = false;
                    }
                    else
                    {
                        NextPlayer(sessionName);
                    }

                    SaveSession(sessionName);
                }
            }
        }

        private bool IsWinner (Player player)
        {
            return player.cards.Count == 0 ? true : false;
        }

        private void RemoveCardFromPlayer(Player player, Card card)
        {
            for (int c = 0; c < player.cards.Count; c++)
            {
                if (player.cards[c].color == card.color && player.cards[c].type == card.type && player.cards[c].value == card.value)
                    appState.players.ElementAt(appState.playerTurn).cards.RemoveAt(c);
            }
        }

        private bool IsPlayersTurn (Player player)
        {
            // there should not be id
            if (appState.players.ElementAt(appState.playerTurn).id == player.id)
                return true;

            return false;
        }

        private bool CheckCardWithRules (Card card)
        {
            if (card.value == CardValue.C7)
                return true;

            if (card.value == CardValue.CA)
                return true;

            if (!appState.nextPlayer7 && !appState.nextPlayerAce)
            {
                // Same color? Pass
                if (appState.cardPlayed.color == card.color)
                    return true;

                // Same value? Pass
                if (appState.cardPlayed.value == card.value)
                    return true;
            }

            return false;
        }

        private void NextPlayer (string sessionName)
        {
            appState.playerTurn += 1;
            appState.playerTurn = appState.playerTurn % appState.players.Count;
        }

        [WebMethod]
        public void SkipTurn (string sessionName, int playerID)
        {
            LoadSession(sessionName);

            Player player = appState.players.Find(p => p.id == playerID);

            if (IsPlayersTurn(player))
            {
                if (!appState.nextPlayer7 && !appState.nextPlayerAce)
                {
                    appState.players.ElementAt(appState.playerTurn).cards.Add(appState.cardStack.ElementAt(0));
                    appState.cardStack.RemoveAt(0);
                    
                }
                else if (appState.nextPlayer7)
                {
                    appState.players.ElementAt(appState.playerTurn).cards.Add(appState.cardStack.ElementAt(0));
                    appState.cardStack.RemoveAt(0);
                    appState.players.ElementAt(appState.playerTurn).cards.Add(appState.cardStack.ElementAt(0));
                    appState.cardStack.RemoveAt(0);
                    appState.nextPlayer7 = false;
                }
                else if (appState.nextPlayerAce)
                {
                    appState.nextPlayerAce = false;
                }

                NextPlayer(sessionName);
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
            LoadSession(sessionName);
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
