using System.Collections.Generic;

namespace UniqueUsernames
{
    using System;

    class UniqueUsernames
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var usernamesSet = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (!usernamesSet.Contains(input))
                {
                    usernamesSet.Add(input);
                }
            }
            Console.WriteLine(string.Join("\n", usernamesSet));
        }
    }
}