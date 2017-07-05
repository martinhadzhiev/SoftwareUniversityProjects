namespace SecondNature
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class SecondNature
    {
        static void Main()
        {
            var flowers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).Reverse());
            var buckets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            while (flowers.Count > 0 && buckets.Count > 0)
            {
                var currentFlower = flowers.Pop();
                var currentBucket = buckets.Pop();
            }
        }
    }
}
