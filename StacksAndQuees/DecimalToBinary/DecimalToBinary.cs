namespace DecimalToBinary
{
    using System;
    using System.Collections.Generic;

    class DecimalToBinary
    {
        static void Main()
        {
            var decimalNumber = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            if (decimalNumber == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (decimalNumber != 0)
                {
                    stack.Push(decimalNumber%2);
                    decimalNumber /= 2;
                }
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
