namespace CardSuit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities;
    using Enums;

    public class StartUp
    {
        static void Main()
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();
            List<Card> firstPlayerCards = new List<Card>();
            List<Card> secondPlayerCards = new List<Card>();

            Deck deckOfCards = new Deck();

            while (secondPlayerCards.Count < 5)
            {
                try
                {
                    string[] wantedCard = Console.ReadLine().Split();
                    string rank = wantedCard[0];
                    string suit = wantedCard[2];

                    Card pulledCard = deckOfCards.PullCard(rank, suit);

                    if (firstPlayerCards.Count < 5)
                    {
                        firstPlayerCards.Add(pulledCard);
                    }
                    else if (secondPlayerCards.Count < 5)
                    {
                        secondPlayerCards.Add(pulledCard);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Card playerOneStrongest = firstPlayerCards.Max();
            Card playerTwoStrongest = secondPlayerCards.Max();

            Console.WriteLine(playerOneStrongest.CompareTo(playerTwoStrongest) == 1
                ? $"{firstPlayer} wins with {playerOneStrongest}."
                : $"{secondPlayer} wins with {playerTwoStrongest}.");
        }
    }
}
