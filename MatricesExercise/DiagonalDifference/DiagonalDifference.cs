namespace DiagonalDifference
{
    using System;
    using System.Linq;


    class DiagonalDifference
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            var diagonalSum0 = 0;
            var diagonalSum1 = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                diagonalSum0 += matrix[i][i];
                diagonalSum1 += matrix[i][matrix[i].Length - i - 1];
            }


            Console.WriteLine(Math.Abs(diagonalSum1-diagonalSum0));
        }
    }
}
