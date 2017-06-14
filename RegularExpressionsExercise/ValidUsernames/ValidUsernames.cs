namespace ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    class ValidUsernames
    {
        static void Main()
        {
            var line = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' },StringSplitOptions.RemoveEmptyEntries);
            var pattern = @"^[[a-zA-Z][a-zA-Z0-9_]{2,24}$";
            var list = new List<string>();

            foreach (var s in line)
            {
                if (Regex.IsMatch(s, pattern))
                {
                    list.Add(Regex.Match(s, pattern).Value);
                }
            }

            var usernames = new string[2];

            var maxSum = int.MinValue;

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].Length + list[i+1].Length > maxSum)
                {
                    maxSum = list[i].Length + list[i + 1].Length;
                    usernames[0] = list[i];
                    usernames[1] = list[i + 1];
                }
            }

            Console.WriteLine(usernames[0]);
            Console.WriteLine(usernames[1]);
        }
    }
}
