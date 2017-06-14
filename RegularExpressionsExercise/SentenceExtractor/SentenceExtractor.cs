namespace SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    class SentenceExtractor
    {
        static void Main()
        {
            var keyword = Console.ReadLine();
            var text = Console.ReadLine();
            var pattern = $@"[^.?!]*(?<=[.?\s!]){keyword}(?=[\s.?!])[^.?!]*[.?!]";

            var matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
