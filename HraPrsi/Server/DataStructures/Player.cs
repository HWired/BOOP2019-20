using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Server.DataStructures
{
    public class Player
    {
        public int id { get; private set; }
        public string name = "";
        public List<Card> cards = new List<Card>();
        public bool isCreator = false;

        public Player ()
        {
            id = GenerateID();
        }

        private int GenerateID()
        {
            using (RNGCryptoServiceProvider rg = new RNGCryptoServiceProvider())
            {
                byte[] rno = new byte[4];
                rg.GetBytes(rno);
                return Math.Abs(BitConverter.ToInt32(rno, 0));
            }
        }
    }
}