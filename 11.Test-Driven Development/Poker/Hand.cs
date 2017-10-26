using System;
using System.Collections.Generic;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            return string.Format(this.Cards.Count == 0 ? "There is no cards in this hand": string.Join(", ", this.Cards));
        }
    }
}
