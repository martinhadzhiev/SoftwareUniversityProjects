namespace CardSuit.Entities
{
    using System;
    using Enums;

    public class Card : IComparable<Card>
    {
        private Rank rank;
        private Suit suit;

        public Card(string rank, string suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public string Rank
        {
            get { return this.rank.ToString(); }
            private set
            {
                if (!Enum.TryParse(value, out this.rank))
                {
                    throw new ArgumentException("No such card exists.");
                }
            }
        }

        public string Suit
        {
            get { return this.suit.ToString(); }
            private set
            {
                if (!Enum.TryParse(value, out this.suit))
                {
                    throw new ArgumentException("No such card exists.");
                }
            }
        }

        private int Power
        {
            get { return (int)rank + (int)suit; }
        }

        public int CompareTo(Card other)
        {
            return this.Power.CompareTo(other.Power);
        }

        public override string ToString()
        {
            return $"{this.rank} of {this.suit}";
        }
    }
}
