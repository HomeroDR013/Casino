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

        [TestCase(SuitConstants.Spades)]
        [TestCase(SuitConstants.Clubs)]
        [TestCase(SuitConstants.Diamonds)]
        [TestCase(SuitConstants.Hearts)]
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

        [TestCase(ValueConstants.Ace)]
        [TestCase(ValueConstants.Two)]
        [TestCase(ValueConstants.Three)]
        [TestCase(ValueConstants.Four)]
        [TestCase(ValueConstants.Five)]
        [TestCase(ValueConstants.Six)]
        [TestCase(ValueConstants.Seven)]
        [TestCase(ValueConstants.Eight)]
        [TestCase(ValueConstants.Nine)]
        [TestCase(ValueConstants.Ten)]
        [TestCase(ValueConstants.Jack)]
        [TestCase(ValueConstants.Queen)]
        [TestCase(ValueConstants.King)]
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
