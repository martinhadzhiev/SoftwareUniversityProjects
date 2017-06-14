using System.Text.RegularExpressions;

namespace VowelsCount
{
    using System;

    class VowelsCount
    {
        static void Main()
        {
            var text = Console.ReadLine();

            var regex = new Regex(@"[aeiouyAEIOUY]");

            Console.WriteLine($"Vowels: {regex.Matches(text).Count}");
        }
    }
}
