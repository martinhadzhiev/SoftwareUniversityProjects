namespace ReplaceTag
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceTag
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var pattern = "<a href=\"(.+)\">(.+)</a>";

            while (line != "end")
            {
                if (Regex.IsMatch(line, pattern))
                {
                    Console.WriteLine(Regex.Replace(line,pattern, "[URL href=\"$1\"]$2[/URL]"));
                }
                else
                {
                    Console.WriteLine(line);
                }
                line = Console.ReadLine();
            }
        }
    }
}
