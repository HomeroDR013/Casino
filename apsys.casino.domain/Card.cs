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

        public bool IsValid()
        {
            if (Constants.SuitList.Contains(Suit) && Constants.ValueList.Contains(Value))
                return true;
            else
                return false;
        }

        public void SetMockData()
        {
            this.Suit = Constants.Spades;
            this.Value = Constants.Ace;
        }
    }
}
