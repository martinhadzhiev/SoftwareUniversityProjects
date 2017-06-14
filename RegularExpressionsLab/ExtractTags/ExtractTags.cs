namespace ExtractTags
{
    using System;
    using System.Text.RegularExpressions;


    class ExtractTags
    {
        static void Main()
        {
            var line = Console.ReadLine();
            Regex regex = new Regex(@"<.+?>");

            while (line != "END")
            {
                foreach (Match match in regex.Matches(line))
                {
                    Console.WriteLine(match);
                }

                line = Console.ReadLine();
            }
        }
    }
}
