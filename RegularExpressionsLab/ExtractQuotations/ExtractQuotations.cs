namespace ExtractQuotations
{
    using System;
    using System.Text.RegularExpressions;
    
    class ExtractQuotations
    {
        static void Main()
        {
            var line = Console.ReadLine();

            var regex = new Regex("'(.+?)'|\"(.+?)\"");

            var matches = regex.Matches(line);

            foreach (Match match in matches)
            {
                Console.Write(match.Groups[2]);
                Console.WriteLine(match.Groups[1]);
            }
        }
    }
}
