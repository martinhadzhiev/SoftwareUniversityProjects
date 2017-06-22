namespace TakeTwo
{
    using System;
    using System.Linq;

    class TakeTwo
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .Where(n => n >= 10 && n <= 20)
                .Take(2);

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
