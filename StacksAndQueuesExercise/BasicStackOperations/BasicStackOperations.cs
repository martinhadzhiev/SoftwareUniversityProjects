using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    using System;

    class BasicStackOperations
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            var numbers = Console.ReadLine().Split().Select(num => int.Parse(num)).ToArray();

            int N = int.Parse(input[0]);
            int S = int.Parse(input[1]);
            int X = int.Parse(input[2]);

            var stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
