namespace MatrixOfPalindromes
{
    using System;
    using System.Linq;

    class MatrixOfPalindromes
    {
        static void Main()
        {
            var rowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();


            for (int i = 0; i < rowsAndCols[0]; i++)
            {
                for (int j = 0; j < rowsAndCols[1]; j++)
                {
                    Console.Write($"{alphabet[i]}{alphabet[i+j]}{alphabet[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
