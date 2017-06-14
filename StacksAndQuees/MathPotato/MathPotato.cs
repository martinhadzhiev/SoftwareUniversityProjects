namespace MathPotato
{
    using System;
    using System.Collections.Generic;

    class MathPotato
    {
        static void Main()
        {
            var children = Console.ReadLine().Split(' ');

            var queue = new Queue<string>(children);
            int number = int.Parse(Console.ReadLine());
            int cycle = 1;

            while (queue.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                if (PrimeTool.IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                cycle++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }

    internal class PrimeTool
    {
        public static bool IsPrime(int number)
        {
            if (number == 2)
            {
                return true;
            }
            else if(number == 1 || number == 0)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0 && i != number)
                        return false;
                }
                return true;
            }
        }
    }
}
