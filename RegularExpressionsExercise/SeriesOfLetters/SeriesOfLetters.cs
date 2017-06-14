namespace SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    class SeriesOfLetters
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"(.)\1+";

            Console.WriteLine(Regex.Replace(input,pattern,"$1"));
        }
    }
}
