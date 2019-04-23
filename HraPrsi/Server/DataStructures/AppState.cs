using System.Collections.Generic;

namespace Server.DataStructures
{
    public class AppState
    {
        public List<Player> players = new List<Player>();
        public List<Card> cardStack = new List<Card>();
        public Card topCardStackPlayed = new Card();

        public bool gameStarted = false;
        public int playerTurn = 0;
    }
}