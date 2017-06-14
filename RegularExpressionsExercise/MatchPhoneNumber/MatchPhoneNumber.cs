namespace MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;


    class MatchPhoneNumber
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var pattern = @"(^\+359[ ]2[ ][0-9]{3} [0-9]{4}$)|(^\+359[-]2[-][0-9]{3}-[0-9]{4}$)";

            while (line != "end")
            {
                if (Regex.IsMatch(line, pattern))
                {
                    Console.WriteLine(line);
                }
                line = Console.ReadLine();
            }
        }
    }
}
