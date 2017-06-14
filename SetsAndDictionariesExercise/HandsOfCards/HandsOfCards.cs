using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    using System;

    class HandsOfCards
    {
        static void Main()
        {
            var players = new Dictionary<string, HashSet<string>>();

            var input = Console.ReadLine();

            while (input != "JOKER")
            {
                var inputParams = input
                    .Split(':');

                var name = inputParams[0];
                var cards = new HashSet<string>(inputParams[1].Split(new []{' ',','},StringSplitOptions.RemoveEmptyEntries));

                if (!players.ContainsKey(name))
                {
                    players[name] = cards;
                }
                else
                {
                    players[name].UnionWith(cards);
                }


                input = Console.ReadLine();
            }

            PrintResults(players);
        }

        private static void PrintResults(Dictionary<string, HashSet<string>> players)
        {
            foreach (var player in players)
            {
                var score = CalcuateScore(player.Value);

                Console.WriteLine($"{player.Key}: {score}");
            }
        }

        private static int CalcuateScore(HashSet<string> playerCards)
        {
            var totalScore = 0;

            foreach (var card in playerCards)
            {
                int powerInt;
                var power = card.Substring(0, card.Length - 1);
                var type = card[card.Length - 1];
                var isNumber = int.TryParse(power, out powerInt);

                if (!isNumber)
                {
                    switch (power)
                    {
                        case "J":
                            powerInt = 11;
                            break;
                        case "Q":
                            powerInt = 12;
                            break;
                        case "K":
                            powerInt = 13;
                            break;
                        case "A":
                            powerInt = 14;
                            break;
                    }
                }
                switch (type)
                {
                    case 'S':
                        powerInt *= 4;
                        break;
                    case 'H':
                        powerInt *= 3;
                        break;
                    case 'D':
                        powerInt *= 2;
                        break;
                    case 'C':
                        powerInt *= 1;
                        break;

                }
                totalScore += powerInt;
            }

            return totalScore;
        }
    }
}
