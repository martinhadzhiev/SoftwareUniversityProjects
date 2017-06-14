namespace ReverseAndExclude
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class ReverseAndExclude
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var divisor = int.Parse(Console.ReadLine());

            Predicate<int> isDividable = n => n % divisor == 0;

            var result = Reverse_n_Exclude(isDividable, numbers);

            Console.WriteLine(string.Join(" ",result));
        }

        private static List<int> Reverse_n_Exclude(Predicate<int> isDividable, List<int> numbers)
        {
            var nums = new List<int>();

            foreach (var num in numbers)
            {
                if (!isDividable(num))
                {
                    nums.Add(num);
                }
            }

            var result = new List<int>();

            for (int i = nums.Count - 1; i >= 0; i--)
            {
                result.Add(nums[i]);
            }

            return result;
        }
    }
}
