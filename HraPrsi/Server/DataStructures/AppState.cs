using System.Collections.Generic;

namespace Server.DataStructures
{
    public class AppState
    {
        public bool gameStarted = false;
        public List<Player> players = new List<Player>();
    }
}