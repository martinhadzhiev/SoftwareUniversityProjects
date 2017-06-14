namespace ExtractIntigerNumbers
{
    using System;
    using System.Text.RegularExpressions;
    
    class ExtractIntigerNumbers
    {
        static void Main()
        {
            var text = Console.ReadLine();

            var regex = new Regex(@"[\d]+");
            MatchCollection matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
