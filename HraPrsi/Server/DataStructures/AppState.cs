﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Server.DataStructures
{
    public class AppState
    {
        public List<Player> players { get; private set; } = new List<Player>();
        public List<Card> cardStack { get; set; } = new List<Card>();
        public Card cardPlayed { get; private set; } = new Card();

        public bool gameStarted { get; set; } = false;
        public string winner = "";
        public int playerTurn { get; set; } = 0;

        public bool nextPlayerAce = false;
        public bool nextPlayer7 = false;

        public void StartGame ()
        {
            gameStarted = true;
        }

        public void AddPlayer (Player player)
        {
            if (!gameStarted)
                players.Add(player);
        }

        public void SetPlayedCard (Card card)
        {
            cardPlayed = card;
        }
    }
}