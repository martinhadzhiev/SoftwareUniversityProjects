using System.Collections.Generic;

namespace KnightGame
{
    using System;
    using System.Linq;

    class KnightGame
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var chessDesk = new char[n][];

            var knightIndexes = new List<string>();

            for (int i = 0; i < chessDesk.Length; i++)
            {
                chessDesk[i] = Console.ReadLine().Trim().ToCharArray();
            }

            CollectKnightIndexes(chessDesk, knightIndexes);

            int counter = 0;
            
            while (true)
            {
                int rToRemove = -1;
                int cToRemove = -1;
                var maxCount = int.MinValue;

                foreach (var knightIndex in knightIndexes)
                {
                    var count = 0;

                    var row = int.Parse(knightIndex.Split().FirstOrDefault());
                    var col = int.Parse(knightIndex.Split().Skip(1).FirstOrDefault());

                    if (knightIndexes.Contains($"{row - 1} {col - 2}"))
                    {
                        count++;
                    }
                    if (knightIndexes.Contains($"{row - 1} {col + 2}"))
                    {
                        count++;
                    }
                    if (knightIndexes.Contains($"{row + 1} {col - 2}"))
                    {
                        count++;
                    }
                    if (knightIndexes.Contains($"{row + 1} {col + 2}"))
                    {
                        count++;
                    }



                    if (knightIndexes.Contains($"{row - 2} {col - 1}"))
                    {
                        count++;
                    }
                    if (knightIndexes.Contains($"{row - 2} {col + 1}"))
                    {
                        count++;
                    }
                    if (knightIndexes.Contains($"{row + 2} {col - 1}"))
                    {
                        count++;
                    }
                    if (knightIndexes.Contains($"{row + 2} {col + 1}"))
                    {
                        count++;
                    }

                    if (count > 0)
                    {
                        if (count > maxCount)
                        {
                            rToRemove = row;
                            cToRemove = col;
                            maxCount = count;
                        }
                    }
                }

                if (rToRemove < 0 || cToRemove < 0)
                {
                    break;
                }

                knightIndexes.Remove($"{rToRemove} {cToRemove}");
                counter++;
            }

            Console.WriteLine(counter);
           
        }

        private static void CollectKnightIndexes(char[][] chessDesk, List<string> knightIndexes)
        {
            for (int row = 0; row < chessDesk.Length; row++)
            {
                for (int col = 0; col < chessDesk[row].Length; col++)
                {
                    if (chessDesk[row][col] == 'K')
                    {
                        knightIndexes.Add($"{row} {col}");
                    }
                }
            }
        }
    }
}
