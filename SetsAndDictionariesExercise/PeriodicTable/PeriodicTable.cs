using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    using System;

    class PeriodicTable
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var periodicElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (string element in elements)
                {
                        periodicElements.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", periodicElements));
        }
    }
}
