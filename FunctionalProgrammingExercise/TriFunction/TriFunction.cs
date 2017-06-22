namespace TriFunction
{
    using System;
    using System.Collections.Generic;

    class TriFunction
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, int> nameSum = name =>
            {
                var sum = 0;
                foreach (var c in name)
                {
                    sum += (int)c;
                }
                return sum;
            };

            Func<string[], int, string> result = (people, num) =>
            {
                
                foreach (var p in people)
                {
                    if (nameSum(p) >= num)
                    {
                        return p;
                    }
                }
                return null;
            };

            var res = result(names, number);

            if (res != null)
            {
                Console.WriteLine(res);
            }
        }
    }
}
