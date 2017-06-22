namespace AverageOfDoubles
{
    using System;
    using System.Linq;

    class AverageOfDoubles
    {
        static void Main()
        {
            var doubles = Console.ReadLine().Split().Select(double.Parse).Average();
            Console.WriteLine($"{doubles:F2}");
        }
    }
}
