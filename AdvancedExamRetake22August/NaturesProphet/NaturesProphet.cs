using System.Collections.Generic;

namespace NaturesProphet
{
    using System;
    using System.Linq;

    class NaturesProphet
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var line = Console.ReadLine();
            var flowers = new List<int[]>();

            while (line != "Bloom Bloom Plow")
            {
                var place = line.Split().Select(int.Parse).ToArray();
                flowers.Add(place);

                line = Console.ReadLine();
            }
            var garden = new int[dimensions[0]][];

            for (int i = 0; i < garden.Length; i++)
            {
                garden[i] = new int[dimensions[1]];
            }

            foreach (var flower in flowers)
            {
                Bloom(flower, garden);
            }

            foreach (var i in garden)
            {
                Console.WriteLine(string.Join(" ",i));
            }
        }

        private static void Bloom(int[] flower, int[][] garden)
        {
            var row = flower[0];
            var col = flower[1];

            var center = garden[row][col];

            for (int i = 0; i < garden.Length; i++)
            {
                garden[row][i]++;
            }

            for (int i = 0; i < garden[0].Length; i++)
            {
                garden[i][col]++;
            }

            garden[row][col] = center + 1;
        }
    }
}
