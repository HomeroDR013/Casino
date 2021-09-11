using apsys.casino.domain.Shared;
using NUnit.Framework;
using apsys.casino.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace apsys.casino.domain.testing
{
    class CardTests
    {
        Card ClassUnderTest;

        [SetUp]
        public void SetUp()
        {
            ClassUnderTest = new Card();
            ClassUnderTest.SetMockData();
        }

        [TestCase(Constants.Spades)]
        [TestCase(Constants.Clubs)]
        [TestCase(Constants.Diamonds)]
        [TestCase(Constants.Hearts)]
        public void IsValid_ValidSuit_ReturnTrue(string suit) 
        {
            //Arrange - Preparación
            ClassUnderTest.Suit = suit;

            //Act - Ejecución
            bool result = ClassUnderTest.IsValid();

            //Assert - Verificación
            Assert.IsTrue(result);
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase("COINS")]
        [TestCase("1")]
        [TestCase("(°-°)/")]
        public void IsValid_InvalidSuit_ReturnFalse(string suit)
        {
            //Arrange - Preparación
            ClassUnderTest.Suit = suit;

            //Act - Ejecución
            bool result = ClassUnderTest.IsValid();

            //Assert - Verificación
            Assert.IsFalse(result);
        }

        [TestCase(Constants.Ace)]
        [TestCase(Constants.Two)]
        [TestCase(Constants.Three)]
        [TestCase(Constants.Four)]
        [TestCase(Constants.Five)]
        [TestCase(Constants.Six)]
        [TestCase(Constants.Seven)]
        [TestCase(Constants.Eight)]
        [TestCase(Constants.Nine)]
        [TestCase(Constants.Ten)]
        [TestCase(Constants.Jack)]
        [TestCase(Constants.Queen)]
        [TestCase(Constants.King)]
        public void IsValid_ValidValue_ReturnTrue(string value)
        {
            //Arrange - Preparación
            ClassUnderTest.Value = value;

            //Act - Ejecución
            bool result = ClassUnderTest.IsValid();

            //Assert - Verificación
            Assert.IsTrue(result);
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase("0")]
        [TestCase("15")]
        [TestCase("B")]
        [TestCase("j")]
        [TestCase("q")]
        [TestCase("k")]
        [TestCase("Bin")]
        [TestCase("-")]
        [TestCase("(-°-)")]
        public void IsValid_InvalidValue_ReturnFalse(string value)
        {
            //Arrange - Preparación
            ClassUnderTest.Value = value;

            //Act - Ejecución
            bool result = ClassUnderTest.IsValid();

            //Assert - Verificación
            Assert.IsFalse(result);
        }
    }
}
