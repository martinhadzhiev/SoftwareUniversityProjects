using System.Collections.Generic;

namespace ListOfPredicates
{
    using System;
    using System.Linq;

    class ListOfPredicates
    {
        static void Main()
        {
            var lenght = int.Parse(Console.ReadLine());
            var divisors = Console.ReadLine()
                .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            if (lenght <= 0) return;
            var numbers = Enumerable
                .Range(1, lenght)
                .ToArray();

            Func<int[], int[], List<int>> check = (nums, divs) =>
            {
                var result = new List<int>();
                var divides = false;

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < divs.Length; j++)
                    {
                        if (nums[i] % divisors[j] != 0)
                        {
                            divides = false;
                            break;
                        }
                        divides = true;
                    }
                    if (divides)
                    {
                        result.Add(nums[i]);
                    }
                }

                return result;
            };

            var list = check(numbers, divisors);

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
