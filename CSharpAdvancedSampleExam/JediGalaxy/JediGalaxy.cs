using System.Collections.Generic;

namespace JediGalaxy
{
    using System;
    using System.Linq;

    class JediGalaxy
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var galaxy = new int[dimensions[0]][];
            CreateGalaxy(dimensions, galaxy);

            var line = Console.ReadLine();

            var counter = 0;
            var ivoStars = new List<int>();
            var evilStars = new List<int>();

            var ivoSumStars = 0;

            while (line != "Let the Force be with you")
            {
                var lineArgs = line.Split().Select(int.Parse).ToArray();
                int row, col;
                if (counter % 2 == 0)
                {
                    row = lineArgs[0] - 1;
                    col = lineArgs[1] + 1;
                }
                else
                {
                    row = lineArgs[0] - 1;
                    col = lineArgs[1] - 1;
                }

                if (counter % 2 == 0)
                {
                    ivoStars = CollectStars(galaxy, row, col, counter);
                }
                else
                {
                    evilStars = CollectStars(galaxy, row, col, counter);
                }

                line = Console.ReadLine();
                counter++;
            }

            foreach (int evilStar in evilStars)
            {
                if (ivoStars.Contains(evilStar))
                {
                    ivoStars.Remove(evilStar);
                }
            }

            Console.WriteLine(ivoStars.Sum());
        }

        private static List<int> CollectStars(int[][] galaxy, int row, int col, int counter)
        {
            var stars = new List<int>();

            if (counter % 2 == 0)
            {
                var c = 0;

                for (int r = galaxy.Length - 1; r >= 0; r--)
                {
                    if (c < galaxy[0].Length)
                    {
                        stars.Add(galaxy[r][c]);
                        c++;
                    }
                }
            }
            else
            {
                var c = galaxy[0].Length - 1;

                for (int r = galaxy.Length - 1; r >= 0; r--)
                {
                    if (c >= 0)
                    {
                        stars.Add(galaxy[r][c]);
                        c--;
                    }
                }
            }

            return stars;
        }

        private static void CreateGalaxy(int[] dimensions, int[][] galaxy)
        {
            for (int i = 0; i < galaxy.Length; i++)
            {
                galaxy[i] = new int[dimensions[1]];
            }

            var counter = 0;

            for (int i = 0; i < galaxy.Length; i++)
            {
                for (int j = 0; j < galaxy[0].Length; j++)
                {
                    galaxy[i][j] = counter;
                    counter++;
                }
            }
        }
    }
}
