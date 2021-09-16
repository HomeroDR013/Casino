using apsys.casino.domain.Shared;
using NUnit.Framework;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace apsys.casino.domain.testing
{
    class BlackJackTests
    {
        [Test]
        public void BuildDeck_ReturnvalidDeck()
        {
            //Arrange
            BlackJack blackJack = new BlackJack();
            //Act
            IEnumerable<Card> deck = blackJack.BuildDeck();
            //Assert
            Assert.NotNull(deck);
            Assert.That(deck.Count(), Is.EqualTo(52));
            foreach (var cardSuit in Constants.SuitList)
            {
                foreach (var cardValue in Constants.ValueList)
                {
                    Assert.That(deck.Count(c => (c.Suit == cardSuit) && (c.Value == cardValue)), Is.EqualTo(1));
                }
            }
            Assert.That(deck.Count(), Is.EqualTo(52));
        }
    }
}
