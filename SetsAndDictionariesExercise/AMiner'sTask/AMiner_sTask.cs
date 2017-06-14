using System.Collections.Generic;

namespace AMiner_sTask
{
    using System;

    class AMiner_sTask
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int count = 0;
            var minerDictionary = new Dictionary<string,int>();

            while (input!= "stop")
            {
                if (!minerDictionary.ContainsKey(input))
                {
                    minerDictionary.Add(input,0);
                }
                {
                    if (count % 2 == 0)
                    {
                        int res = int.Parse(Console.ReadLine());
                        minerDictionary[input] += res;
                    }
                    else
                    {
                        input = Console.ReadLine();
                    }
                }
                count++;
            }

            foreach (KeyValuePair<string, int> kvp in minerDictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
