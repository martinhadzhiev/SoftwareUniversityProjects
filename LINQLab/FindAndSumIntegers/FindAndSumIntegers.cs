namespace FindAndSumIntegers
{
    using System;
    using System.Linq;

    class FindAndSumIntegers
    {
        static void Main()
        {
            int s;
            var nums = Console.ReadLine().Split().Where(n => int.TryParse(n, out s));

            if (nums.Count() == 0)
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine(nums.Select(int.Parse).Sum());
            }
        }
    }
}
