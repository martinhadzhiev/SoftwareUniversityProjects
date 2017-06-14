namespace UseYourChainsBuddy
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class UseYourChainsBuddy
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex("<p>(.*?)<\\/p>");

            var matches = regex.Matches(text);

            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                var reminder = match.Groups[1].Value;
                var result = Regex.Replace(reminder, "[^a-z0-9]+", " ");

                foreach (var c in result)
                {
                    if (c >= 'a' && c <= 'm')
                    {
                        sb.Append((char)(c + 13));
                    }
                    else if (c >= 'n' && c <= 'z')
                    {
                        sb.Append((char)(c - 13));
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
            }
            Console.WriteLine(sb.ToString());

        }
    }
}
