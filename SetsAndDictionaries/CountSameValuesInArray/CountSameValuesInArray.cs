using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    using System;

    class CountSameValuesInArray
    {
        static void Main()
        {
            double[] input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => double.Parse(n)).ToArray();

            SortedDictionary<double,int> numDictionary = new SortedDictionary<double, int>();

            foreach (var num in input)
            {
                if (numDictionary.ContainsKey(num))
                {
                    numDictionary[num]++;
                }
                else
                {
                    numDictionary.Add(num,1);
                }
            }

            foreach (KeyValuePair<double,int> kvp in numDictionary)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
