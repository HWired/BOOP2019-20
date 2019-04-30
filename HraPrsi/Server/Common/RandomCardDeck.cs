using Server.DataStructures;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Web;

namespace Server.Common
{
    public class RandomCardDeck
    {
        private List<Card> cards = new List<Card>();

        public RandomCardDeck ()
        {
            FillList();
            ListOperations.Shuffle(cards);
        }

        private void FillList ()
        {
            CardType cardType = CardType.Heart;
            for (int c = 1; c < 13; c++)
                cards.Add(GetCard(c, cardType));

            cardType = CardType.Diamond;
            for (int c = 1; c < 13; c++)
                cards.Add(GetCard(c, cardType));

            cardType = CardType.Acorn;
            for (int c = 1; c < 13; c++)
                cards.Add(GetCard(c, cardType));

            cardType = CardType.Leaf;
            for (int c = 1; c < 13; c++)
                cards.Add(GetCard(c, cardType));
        }

        private Card GetCard (int i, CardType cardType)
        {
            CardColor cardColor = CardColor.Undefined;
            CardValue cardValue = CardValue.Undefined;
            switch (cardType)
            {
                case CardType.Diamond:
                case CardType.Heart:
                    cardColor = CardColor.Red;
                    break;
                case CardType.Acorn:
                case CardType.Leaf:
                    cardColor = CardColor.Black;
                    break;
            }

            switch (i)
            {
                case 1: cardValue = CardValue.CA; break;
                case 2: cardValue = CardValue.C2; break;
                case 3: cardValue = CardValue.C3; break;
                case 4: cardValue = CardValue.C4; break;
                case 5: cardValue = CardValue.C5; break;
                case 6: cardValue = CardValue.C6; break;
                case 7: cardValue = CardValue.C7; break;
                case 8: cardValue = CardValue.C8; break;
                case 9: cardValue = CardValue.C9; break;
                case 10: cardValue = CardValue.C10; break;
                case 11: cardValue = CardValue.CJ; break;
                case 12: cardValue = CardValue.CQ; break;
                case 13: cardValue = CardValue.CK; break;
            }

            return new Card
            {
                color = cardColor,
                type = cardType,
                value = cardValue
            };
        }

        public List<Card> GetCards ()
        {
            return cards;
        }
    }
}

