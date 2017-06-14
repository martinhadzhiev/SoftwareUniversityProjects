namespace ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;


    class ValidUsernames
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var regex = new Regex(@"^[0-9A-Za-z_-]{3,16}$");

            while (line != "END")
            {
                if (regex.IsMatch(line))
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                line = Console.ReadLine();
            }
        }
    }
}
