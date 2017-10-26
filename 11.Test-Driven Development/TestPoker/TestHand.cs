namespace TestPoker
{
    using System;
    using System.Collections.Generic;
    using Poker;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestHand
    {
        [TestMethod]
        public void ToStringMethodShouldReturnAllCardNames()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            };

            var hand = new Hand(cards);

            Assert.AreEqual(string.Join(", ", cards), hand.ToString(), "ToString method don't return correct value");
        }

        [TestMethod]
        public void ToStringMustReturnThatsHandDontHaveCards()
        {
            var cards = new List<ICard>();

            var hand = new Hand(cards);
            var expectedValue = "There is no cards in this hand";

            Assert.AreEqual(expectedValue, hand.ToString(),
                "ToString method don't work correctly when card list is empty");
        }
    }
}