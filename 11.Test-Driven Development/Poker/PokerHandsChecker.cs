using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards == null)
            {
                throw new NullReferenceException();
            }

            if (hand.Cards.Count != 5)
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = 0; j < hand.Cards.Count; j++)
                {
                    if (j == i)
                    {
                        j++;
                    }

                    if (j >= hand.Cards.Count)
                    {
                        break;
                    }

                    if (hand.Cards[i].Face == hand.Cards[j].Face && hand.Cards[i].Suit == hand.Cards[j].Suit)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            int counter = 0;
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = 0; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        counter++;
                        if (counter == 4)
                        {
                            return true;
                        }
                    }  
                }

                counter = 0;
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            CardSuit flushSuit = hand.Cards[0].Suit;
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (flushSuit != hand.Cards[i].Suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
