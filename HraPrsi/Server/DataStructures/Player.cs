using System.Collections.Generic;

namespace Server.DataStructures
{
    public class Player
    {
        public string name = "";
        public List<Card> cards = new List<Card>();
        public bool isCreator = false;

        public int order = -1;

        public void SetCreator(bool isCreator)
        {
            this.isCreator = isCreator;
        }

        public void SetName (string playerName)
        {
            name = playerName;
        }
    }
}