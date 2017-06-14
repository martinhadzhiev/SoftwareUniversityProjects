using System.Linq;

namespace MaximumSumOf2x2Submatrix
{
    using System;

    class MaximumSumOf2x2Submatrix
    {
        static void Main()
        {
            var martixSizes = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            int[][] matrix = new int[int.Parse(martixSizes[0])][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }

            var maxSquareRow = 0;
            var maxSquareCol = 0;
            var maxSum = int.MinValue;

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    var currentSum = matrix[i][j] + matrix[i][j + 1] + matrix[i+1][j]  + matrix[i+1][j+1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSquareRow = i;
                        maxSquareCol = j;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxSquareRow][maxSquareCol]} {matrix[maxSquareRow][maxSquareCol+1]}");
            Console.WriteLine($"{matrix[maxSquareRow+1][maxSquareCol]} {matrix[maxSquareRow+1][maxSquareCol+1]}");
            Console.WriteLine(maxSum);
        }
    }
}
