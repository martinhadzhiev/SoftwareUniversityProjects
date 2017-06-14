using System.Collections.Generic;

namespace CountSymbols
{
    using System;

    class CountSymbols
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var symbolsDictionary = new SortedDictionary<char,int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (symbolsDictionary.ContainsKey(input[i]))
                {
                    symbolsDictionary[input[i]]++;
                }
                else
                {
                    symbolsDictionary.Add(input[i],1);
                }
            }

            foreach (KeyValuePair<char, int> kvp in symbolsDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
