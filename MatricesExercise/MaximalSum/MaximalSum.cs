namespace MaximalSum
{
    using System;
    using System.Linq;

    class MaximalSum
    {
        static void Main()
        {
            var rowAndCol = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[][] cube = new int[rowAndCol[0]][];

            for (int row = 0; row < rowAndCol[0]; row++)
            {
                cube[row] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            int squareRow = 0;
            int squareCol = 0;
            var sum = long.MinValue;

            for (int i = 0; i < cube.Length - 2; i++)
            {
                for (int j = 0; j < cube[i].Length - 2; j++)
                {
                    var currentSum = cube[i][j] + cube[i][j + 1] + cube[i][j + 2] +
                                   cube[i + 1][j] + cube[i + 1][j + 1] + cube[i + 1][j + 2] +
                                   cube[i + 2][j] + cube[i + 2][j + 1] + cube[i + 2][j + 2];

                    if (currentSum > sum)
                    {
                        squareCol = j;
                        squareRow = i;
                        sum = currentSum;
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"{cube[squareRow][squareCol]} {cube[squareRow][squareCol+1]} {cube[squareRow][squareCol+2]}");
            Console.WriteLine($"{cube[squareRow+1][squareCol]} {cube[squareRow + 1][squareCol+1]} {cube[squareRow + 1][squareCol+2]}");
            Console.WriteLine($"{cube[squareRow+2][squareCol]} {cube[squareRow + 2][squareCol+1]} {cube[squareRow + 2][squareCol+2]}");
        }
    }
}
