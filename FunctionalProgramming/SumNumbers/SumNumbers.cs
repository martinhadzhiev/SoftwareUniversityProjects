namespace SumNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine($"{numbers.Length}\n\r{numbers.Sum()}");
        }
    }
}
