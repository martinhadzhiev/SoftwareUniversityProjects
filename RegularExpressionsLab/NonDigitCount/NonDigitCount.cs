using System.Text.RegularExpressions;

namespace NonDigitCount
{
    using System;

    class NonDigitCount
    {
        static void Main()
        {
            var text = Console.ReadLine();

            var regex= new Regex(@"\D");

            Console.WriteLine($"Non-digits: {regex.Matches(text).Count}");
        }
    }
}
