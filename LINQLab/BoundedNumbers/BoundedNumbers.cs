namespace BoundedNumbers
{
    using System;
    using System.Linq;

    class BoundedNumbers
    {
        static void Main()
        {
            var boundries = Console.ReadLine().Split().OrderBy(n => n).ToArray();
            var lower = int.Parse(boundries[0]);
            var upper = int.Parse(boundries[1]);

            var result = Console.ReadLine().Split().Select(int.Parse).Where(n => n >= lower && n <= upper);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
