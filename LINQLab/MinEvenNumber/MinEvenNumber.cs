namespace MinEvenNumber
{
    using System;
    using System.Linq;

    class MinEvenNumber
    {
        static void Main()
        {
            var number = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .OrderBy(n => n)
                .FirstOrDefault(n => n % 2 == 0);

            if (number == 0)
            {
                Console.WriteLine("No match"); 
                return;
            }
            Console.WriteLine($"{number:F2}");

        }
    }
}
