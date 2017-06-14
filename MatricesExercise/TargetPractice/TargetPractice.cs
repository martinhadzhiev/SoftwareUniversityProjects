namespace TargetPractice
{
    using System;
    using System.Linq;


    class TargetPractice
    {
        static void Main()
        {
            var rowsAndCols = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var snakeString = Console.ReadLine().ToCharArray();
            var shotParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var row = rowsAndCols[0];
            var col = rowsAndCols[1];

            char[][] snake = new char[row][];

            SnakeMakingMethod(snakeString, row, col, snake);

            var rowShot = shotParameters[0];
            var colShot = shotParameters[1];
            var radius = shotParameters[2];

            ShotingMethod(rowShot, colShot, radius, snake);
            FallingMethod(snake);

            foreach (var s in snake)
            {
                Console.WriteLine(string.Join("", s));
            }
        }

        private static void FallingMethod(char[][] snake)
        {
            for (int i = 0; i < snake.GetLength(0); i++)
            {
                for (int row = 0; row < snake.Length - 1; row++)
                {
                    for (int col = 0; col < snake[row].Length; col++)
                    {
                        if (snake[row + 1][col] == ' ' && snake[row][col] != ' ')
                        {
                            snake[row + 1][col] = snake[row][col];
                            snake[row][col] = ' ';
                        }
                    }
                }
            }

        }

        private static void ShotingMethod(int rowShot, int colShot, int radius, char[][] snake)
        {
            for (int i = 0; i < snake.Length; i++)
            {
                for (int j = 0; j < snake[i].Length; j++)
                {
                    if ((i - rowShot) * (i - rowShot) + (j - colShot) * (j - colShot) <= radius * radius)
                    {
                        snake[i][j] = ' ';
                    }
                }
            }
        }

        private static void SnakeMakingMethod(char[] snakeString, int row, int col, char[][] snake)
        {
            var counter = 0;
            bool direction = true;
            for (int i = row - 1; i >= 0; i--)
            {
                snake[i] = new char[col];

                if (direction)
                {
                    for (int j = snake[i].Length - 1; j >= 0; j--)
                    {
                        if (counter >= snakeString.Length) counter = 0;

                        snake[i][j] = snakeString[counter];
                        counter++;
                    }
                    direction = false;
                }
                else
                {
                    for (int j = 0; j < snake[i].Length; j++)
                    {
                        if (counter >= snakeString.Length) counter = 0;

                        snake[i][j] = snakeString[counter];
                        counter++;
                    }
                    direction = true;
                }
            }

        }
    }
}
