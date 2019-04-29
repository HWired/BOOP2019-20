using System.Collections.Generic;

namespace Server.DataStructures
{
    public class Player
    {
        private int id = 0;
        private string name = "";
        private List<Card> cards = new List<Card>();
        private bool isCreator = false;

        public Player (int id, string name, bool isCreator)
        {
            this.id = id;
            this.name = name;
            this.isCreator = isCreator;
        }

        public string GetName ()
        {
            return name;
        }

        public List<Card> GetCards ()
        {
            return cards;
        }
    }
}