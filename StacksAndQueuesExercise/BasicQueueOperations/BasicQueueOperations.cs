using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    using System;

    class BasicQueueOperations
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();
            int N = int.Parse(input[0]);
            int S = int.Parse(input[1]);
            int X = int.Parse(input[2]);

            var queue = new Queue<int>();

            foreach (int num in numbers)
            {
                queue.Enqueue(num);
            }

            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }else if (queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
