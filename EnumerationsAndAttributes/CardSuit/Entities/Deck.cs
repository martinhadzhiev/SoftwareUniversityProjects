namespace CardSuit.Entities
{
    using System;
    using Enums;
    using System.Collections.Generic;
    using System.Linq;

    public class Deck
    {
        private readonly IList<Card> cards;

        public Deck()
        {
            this.cards = new List<Card>();
            CreateCards();
        }

        private void CreateCards()
        {
            foreach (string suit in typeof(Suit).GetEnumNames())
            {
                foreach (string rank in typeof(Rank).GetEnumNames())
                {
                    this.cards.Add(new Card(rank, suit));
                }
            }
        }

        public Card PullCard(string rank ,string suit)
        {
            ValidateCard(rank, suit);

            Card pulledCard = this.cards.FirstOrDefault(c => c.Rank== rank && c.Suit == suit);

            if (pulledCard == null)
            {
                throw new InvalidOperationException("Card is not in the deck.");
            }

            this.cards.Remove(pulledCard);

            return pulledCard;
        }

        private void ValidateCard(string rank, string suit)
        {
            Card cardForValidation = new Card(rank,suit);
        }
    }
}
