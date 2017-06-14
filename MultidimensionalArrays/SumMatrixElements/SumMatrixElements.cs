using System.Linq;

namespace SumMatrixElements
{
    using System;

    class SumMatrixElements
    {
        static void Main()
        {
            var matrixArgs = Console.ReadLine()
                .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[][] matrix = new int[matrixArgs[0]][];

            for (int i = 0; i < matrixArgs[0]; i++)
            {
                var rowArgs = Console.ReadLine()
                    .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
               
                    matrix[i] = rowArgs;
            }

            var sum = 0;

            foreach (var array in matrix)
            {
                sum += array.Sum();
            }

            Console.WriteLine(matrixArgs[0]);
            Console.WriteLine(matrixArgs[1]);
            Console.WriteLine(sum);

        }
    }
}
