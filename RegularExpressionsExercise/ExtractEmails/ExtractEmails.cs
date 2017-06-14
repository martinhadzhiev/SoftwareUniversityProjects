using System.Text.RegularExpressions;

namespace ExtractEmails
{
    using System;

    class ExtractEmails
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var pattern = @"^([a-zA-Z0-9]+[\.\-_]?[a-zA-Z0-9]+)@[a-zA-Z]+[\.\-]?([a-zA-Z\.\-]?)+\.[a-z]+";

            var regex = new Regex(pattern);

            foreach (var s in input)
            {
                if (regex.IsMatch(s))
                {
                    Console.WriteLine(regex.Match(s));
                }
            }
        }
    }
}
