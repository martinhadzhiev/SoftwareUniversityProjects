using System.Collections.Generic;

namespace CalculateSequenceWithQueue
{
    using System;

    class CalculateSequenceWithQueue
    {
        static void Main()
        {
            long firstNumber = long.Parse(Console.ReadLine());

            var numbers = new Queue<long>();
            int dequeueCount = 50;

            numbers.Enqueue(firstNumber);

            for (int i = 0; i < dequeueCount; i++)
            {
                var currentNumber = numbers.Dequeue();
                Console.Write(currentNumber + " ");
                numbers.Enqueue(currentNumber+1);
                numbers.Enqueue(currentNumber * 2+1);
                numbers.Enqueue(currentNumber + 2);
            }
            Console.WriteLine();

        }
    }
}
