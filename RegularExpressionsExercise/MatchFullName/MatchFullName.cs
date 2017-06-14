using System.Text.RegularExpressions;

namespace MatchFullName
{
    using System;

    class MatchFullName
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var regex = new Regex(@"^[A-Z][a-z]+ [A-Z][a-z]+$");

            while (line!="end")
            {
                if (regex.IsMatch(line))
                {
                    Console.WriteLine(line);
                }

                line = Console.ReadLine();
            }
        }
    }
}
