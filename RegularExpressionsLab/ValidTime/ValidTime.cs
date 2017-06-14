namespace ValidTime
{
    using System;
    using System.Text.RegularExpressions;

    class ValidTime
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var regex = new Regex(@"((^[0]?[0-9]:[0-5]?[0-9]:[0-5]?[0-9] [A|P]M$)|(^[1]?[0-2]:[0-5][0-9]:[0-5][0-9] [A|P]M$))");

           
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
