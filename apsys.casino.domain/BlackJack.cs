using apsys.casino.domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace apsys.casino.domain
{
    public class BlackJack
    {
        public IEnumerable<Card> BuildDeck()
        {
            IList<Card> cards = new List<Card>();
            foreach (var cardSuit in Constants.SuitList)
            {
                foreach (var cardValue in Constants.ValueList)
                    cards.Add(new Card { Suit = cardSuit, Value = cardValue });
            }
            return cards;
        }
    }
}
