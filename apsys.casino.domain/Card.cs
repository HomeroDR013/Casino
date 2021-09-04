using apsys.casino.domain.Shared;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace apsys.casino.domain
{
    public class Card
    {
        public string Suit { get; set; }

        public string Value { get; set; }

        public static List<string> SuitList = new List<string>
        (new string[]
        {
            SuitConstants.Spades,
            SuitConstants.Clubs,
            SuitConstants.Diamonds,
            SuitConstants.Hearts

        });

        public static List<string> ValueList = new List<string>
        (new string[]
        {
            ValueConstants.Ace,
            ValueConstants.Two,
            ValueConstants.Three,
            ValueConstants.Four,
            ValueConstants.Five,
            ValueConstants.Six,
            ValueConstants.Seven,
            ValueConstants.Eight,
            ValueConstants.Nine,
            ValueConstants.Ten,
            ValueConstants.Jack,
            ValueConstants.Queen,
            ValueConstants.King

        });

        public bool IsValid()
        {
            if (SuitList.Contains(Suit) && ValueList.Contains(Value))
                return true;
            else
                return false;
        }

        public void SetMockData()
        {
            this.Suit = SuitConstants.Spades;
            this.Value = ValueConstants.Ace;
        }
    }
}
