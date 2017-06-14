using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbersWithAStack
{
    using System;

    class ReverseNumbersWithAStack
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();

            var stack = new Stack<string>();

            foreach (string s in input)
            {
                stack.Push(s);
            }

            while (stack.Count != 0)
            {
                Console.Write($"{stack.Pop()} ");
            }
            Console.WriteLine();
        }
    }
}
