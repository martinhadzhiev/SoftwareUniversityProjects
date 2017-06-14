using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    using System;

    class SetsOfElements
    {
        static void Main()
        {
            int[] lenghtInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int setsLenght = lenghtInput[0] + lenghtInput[1];

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < setsLenght; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i < lenghtInput[0] && !firstSet.Contains(number))
                {
                    firstSet.Add(number);
                }
                else if(i >= lenghtInput[0] && !secondSet.Contains(number))
                {
                    secondSet.Add(number);
                }
            }

            foreach (var num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }
    }
}
