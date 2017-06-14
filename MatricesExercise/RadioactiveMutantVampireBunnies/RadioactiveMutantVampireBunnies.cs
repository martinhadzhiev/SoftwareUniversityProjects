namespace RadioactiveMutantVampireBunnies
{
    using System;
    using System.Linq;

    class RadioactiveMutantVampireBunnies
    {
        private static int[] lastLocation = new int[2];

        static void Main()
        {
            var dimensions = Console.ReadLine().Split();
            var rows = int.Parse(dimensions[0]);
            var cols = int.Parse(dimensions[1]);

            char[][] lair = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                lair[i] = Console.ReadLine().ToCharArray();
            }

            var moves = Console.ReadLine().ToCharArray();

            for (int i = 0; i < moves.Length; i++)
            {
                var playerLocation = FindPlayer(lair);
                HasWon(playerLocation, lair);
                IsEaten(playerLocation, lair);
                MovePlayer(playerLocation, lair, moves[i]);
                SpreadBunnies(lair);
            }
            HasWon(lastLocation, lair);
            IsEaten(lastLocation, lair);


        }

        private static void SpreadBunnies(char[][] lair)
        {
            for (int rowIndex = 0; rowIndex < lair.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < lair[rowIndex].Length; colIndex++)
                {
                    if (lair[rowIndex][colIndex] == 'B')
                    {
                        MarkBunnies(lair, rowIndex, colIndex);
                    }
                }
            }
            MultiplyBunnies(lair);
        }

        private static void MultiplyBunnies(char[][] lair)
        {
            for (int rowIndex = 0; rowIndex < lair.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < lair[rowIndex].Length; colIndex++)
                {
                    if (lair[rowIndex][colIndex] == 'b')
                    {
                        lair[rowIndex][colIndex] = 'B';
                    }
                }
            }
        }

        private static void MarkBunnies(char[][] lair, int rowIndex, int colIndex)
        {
            if (rowIndex > 0)
            {
                lair[rowIndex - 1][colIndex] = 'b';
            }
            if (colIndex > 0)
            {
                lair[rowIndex][colIndex - 1] = 'b';
            }
            if (rowIndex < lair.Length - 1)
            {
                lair[rowIndex + 1][colIndex] = 'b';
            }
            if (colIndex < lair[rowIndex].Length - 1)
            {
                lair[rowIndex][colIndex + 1] = 'b';
            }
        }

        private static void MovePlayer(int[] playerLocation, char[][] lair, char move)
        {
            switch (move)
            {
                case 'U':
                    var currentLocation = FindPlayer(lair);
                    var playerRow = currentLocation[0];
                    var playerCol = currentLocation[1];

                    lair[playerRow][playerCol] = '.';

                    if (playerRow > 0)
                    {
                        if (lair[playerRow - 1][playerCol] == 'B')
                        {
                            foreach (var row in lair)
                            {
                                Console.WriteLine(string.Join("", row));
                            }
                            Console.WriteLine($"dead: {lastLocation[0]} {lastLocation[1]}");
                        }

                        lair[playerRow - 1][playerCol] = 'P';
                    }
                    break;

                case 'D':
                    currentLocation = FindPlayer(lair);
                    playerRow = currentLocation[0];
                    playerCol = currentLocation[1];

                    lair[playerRow][playerCol] = '.';

                    if (playerRow < lair.Length - 1)
                    {
                        if (lair[playerRow + 1][playerCol] == 'B')
                        {
                            foreach (var row in lair)
                            {
                                Console.WriteLine(string.Join("", row));
                            }
                            Console.WriteLine($"dead: {lastLocation[0]} {lastLocation[1]}");
                        }

                        lair[playerRow + 1][playerCol] = 'P';
                    }
                    break;

                case 'L':
                    currentLocation = FindPlayer(lair);
                    playerRow = currentLocation[0];
                    playerCol = currentLocation[1];

                    lair[playerRow][playerCol] = '.';

                    if (playerCol > 0)
                    {
                        if (lair[playerRow][playerCol - 1] == 'B')
                        {
                            foreach (var row in lair)
                            {
                                Console.WriteLine(string.Join("", row));
                            }
                            Console.WriteLine($"dead: {lastLocation[0]} {lastLocation[1]}");
                        }
                        lair[playerRow][playerCol - 1] = 'P';
                    }
                    break;

                case 'R':
                    currentLocation = FindPlayer(lair);
                    playerRow = currentLocation[0];
                    playerCol = currentLocation[1];

                    lair[playerRow][playerCol] = '.';

                    if (playerCol < lair[playerRow].Length - 1)
                    {
                        if (lair[playerRow][playerCol + 1] == 'B')
                        {
                            foreach (var row in lair)
                            {
                                Console.WriteLine(string.Join("", row));
                            }
                            Console.WriteLine($"dead: {lastLocation[0]} {lastLocation[1]}");
                        }
                        lair[playerRow][playerCol + 1] = 'P';
                    }
                    break;
            }
        }

        private static void IsEaten(int[] playerLocation, char[][] lair)
        {
            if (lair[lastLocation[0]][lastLocation[1]] == 'B')
            {
                foreach (var row in lair)
                {
                    Console.WriteLine(string.Join("", row));
                }
                Console.WriteLine($"dead: {lastLocation[0]} {lastLocation[1]}");
                Environment.Exit(0);
            }
        }

        private static void HasWon(int[] playerLocation, char[][] lair)
        {
            if (lair[lastLocation[0]][lastLocation[1]] == '.')
            {
                foreach (var row in lair)
                {
                    Console.WriteLine(string.Join("", row));
                }
                Console.WriteLine($"won: {lastLocation[0]} {lastLocation[1]}");

                Environment.Exit(0);
            }
        }

        private static int[] FindPlayer(char[][] lair)
        {
            for (int rowIndex = 0; rowIndex < lair.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < lair[rowIndex].Length; colIndex++)
                {
                    if (lair[rowIndex][colIndex] == 'P')
                    {
                        lastLocation = new[] { rowIndex, colIndex };
                        return new[] { rowIndex, colIndex };
                    }
                }
            }
            return new[] { -1 };
        }
    }
}
