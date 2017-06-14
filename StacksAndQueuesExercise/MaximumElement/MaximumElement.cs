using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    using System;

    class MaximumElement
    {
        static void Main()
        {
            var stack = new Stack<int>();

            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;

            var maxNumbers = new Stack<int>();

            for (int i = 1; i <= n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(num => int.Parse(num)).ToArray();

                if (input[0] == 1)
                {
                    if (input[1] > maxNumber)
                    {
                        maxNumber = input[1];
                        maxNumbers.Push(input[1]);
                    }
                  stack.Push(input[1]);  
                }
                else if(input[0] == 2)
                {
                    if (stack.Pop() == maxNumber)
                    {
                        maxNumbers.Pop();
                        maxNumber = int.MinValue;
                    }
                    if (maxNumbers.Count !=0)
                    {
                        maxNumber = maxNumbers.Peek();
                    }
                }else if (input[0] == 3)
                {
                    Console.WriteLine(maxNumber);
                }
            }

        }
    }
}
