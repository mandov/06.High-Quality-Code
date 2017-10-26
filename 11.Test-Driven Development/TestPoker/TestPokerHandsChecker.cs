namespace TestPoker
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class TestPokerHandsChecker
    {
        [TestMethod]
        public void IsValidHandShouldWorkCorrectWithFiveDifferentCards()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Clubs),
            };
            var hand = new Hand(cards);
            var pokerHandsChecker = new PokerHandsChecker();

            Assert.IsTrue(pokerHandsChecker.IsValidHand(hand), "isValidHand returns incorrect result");
        }

        [TestMethod]
        public void IsValidShouldReturnFalseIfCardsAreNotFive()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Hearts),
            };
            var hand = new Hand(cards);
            var pokerHandsCheker = new PokerHandsChecker();

            Assert.IsFalse(pokerHandsCheker.IsValidHand(hand),
                "isValidHand don't returns correct result,when works with greater or less than five cards");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsValidShouldThrowNullReferenceException()
        {
            List<ICard> cards = null;
            var hand = new Hand(cards);
            var pokerHandsChecker = new PokerHandsChecker();
            pokerHandsChecker.IsValidHand(hand);
        }

        [TestMethod]
        public void IsFlushShouldReturnCorrectResult()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            };
            var hand = new Hand(cards);
            var pokerHandsChecker = new PokerHandsChecker();

            Assert.IsTrue(pokerHandsChecker.IsFlush(hand),"IsFlush don't work correctly!");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFlushShouldThrowNullReferenceException()
        {
            List<ICard> cards = null;
            var hand = new Hand(cards);
            var pokerHandsChecker = new PokerHandsChecker();
            pokerHandsChecker.IsFlush(hand);
        }

        [TestMethod]
        public void IsFlushShouldntWorkWithoutFiveCards()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Hearts),
            };
            var hand = new Hand(cards);
            var pokerHandsChecker = new PokerHandsChecker();

            Assert.IsFalse(pokerHandsChecker.IsFlush(hand), "IsFlush don't work correctly,because works with more or less than five cards");
        }

        [TestMethod]
        public void IsFlushShouldntWorksProperlyWithDifferentCardSuits()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Spades),
            };
            var hand = new Hand(cards);
            var pokerHandsChecker = new PokerHandsChecker();

            Assert.IsFalse(pokerHandsChecker.IsFlush(hand), "IsFlush don't return correct result,because card suits are different");
        }

        [TestMethod]
        public void TestIfIsFourOfAKindReturnsCorrectResult()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades),
            };
            var hand = new Hand(cards);
            var pokerHandsChecker = new PokerHandsChecker();

            Assert.IsTrue(pokerHandsChecker.IsFourOfAKind(hand), "IsFourOfAkind don't return correct result");
        }

        [TestMethod]
        public void IsFourOfAKindShouldReturnFalseWhenWorksWithMoreOrLessThanFiveCards()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Hearts),
            };
            var hand = new Hand(cards);
            var pokerHandsChecker = new PokerHandsChecker();

            Assert.IsFalse(pokerHandsChecker.IsFourOfAKind(hand), "IsFourOfAkind don't return correct result");
        }

        [TestMethod]
        public void TestIfIsFourOfAKindWillReturnFalseWithoutFourOfAKindCards()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Clubs),

            };
            var hand = new Hand(cards);
            var pokerHandsChecker = new PokerHandsChecker();

            Assert.IsFalse(pokerHandsChecker.IsFourOfAKind(hand), "IsFourOfAkind don't return correct result");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFourOfAKindShouldThrowNullReferenceException()
        {
            List<ICard> cards = null;
            var hand = new Hand(cards);
            var pokerHandsChecker = new PokerHandsChecker();
            pokerHandsChecker.IsFourOfAKind(hand);
        }
    }
}