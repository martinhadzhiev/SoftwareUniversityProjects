using System.Linq;

namespace _2x2SquaresInMatrix
{
    using System;

    class _2x2SquaresInMatrix
    {
        static void Main()
        {
            var rowsAndCols = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char [][] matrix = new char[rowsAndCols[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();
            }

            var equalSquares = 0;

            for (int i = 0; i < matrix.Length-1; i++)
            {
                for (int j = 0; j < matrix[i].Length-1; j++)
                {
                    if (matrix[i][j] == matrix[i][j+1] && matrix[i+1][j] == matrix[i][j + 1] && matrix[i + 1][j+1] == matrix[i][j + 1])
                    {
                        equalSquares++;
                    }
                }
            }

            Console.WriteLine(equalSquares);
        }
    }
}
