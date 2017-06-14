using System.Collections.Generic;
using System.Linq;

namespace StackFibonacci
{
    using System;

    class StackFibonacci
    {
        static void Main()
        {
            var nthNumber = int.Parse(Console.ReadLine());
            var fibStack = new Stack<long>();

            //GetFibonacii(nthNumber);

            fibStack.Push(0);
            fibStack.Push(1);

            for (int i = 1; i < nthNumber; i++)
            {
                var lastFib = fibStack.Pop();
                var prevFib = fibStack.Pop();
                fibStack.Push(lastFib);
                fibStack.Push(prevFib+lastFib);
            }

            Console.WriteLine(fibStack.Max());
        }

       
    }
}
