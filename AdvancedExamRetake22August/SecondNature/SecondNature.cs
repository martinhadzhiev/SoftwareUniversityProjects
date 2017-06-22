namespace SecondNature
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class SecondNature
    {
        static void Main()
        {
            var flowers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var buckets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            var secondNature = new List<int>();

            while (flowers.Count != 0 && buckets.Count != 0)
            {
                if (buckets.Peek() - flowers.Peek() > 0)
                {
                    var remainingWater = buckets.Pop() - flowers.Dequeue();
                    buckets.Push(buckets.Pop() + remainingWater);
                }
                else if (buckets.Peek() - flowers.Peek() > 0)
                {
                    var flower = flowers.Dequeue();
                    secondNature.Add(flower);

                    while (flower <= 0)
                    {
                        flower -= buckets.Peek();
                        var remainingWater = buckets.Peek() - flower;
                        if (remainingWater > 0 && buckets.Count > 1)
                        {
                            buckets.Push(buckets.Pop() + remainingWater);
                        }
                    }
                    if (flower != 0)
                    {
                        secondNature.RemoveAt(secondNature.Count - 1);
                    }
                }
                else
                {
                    secondNature.Add(flowers.Dequeue());
                    buckets.Pop();
                }
            }

            if (flowers.Count < buckets.Count)
            {
                Console.WriteLine(string.Join(" ", buckets));
            }
            else
            {
                Console.WriteLine(string.Join(" ", flowers));
            }

            if (secondNature.Count > 0)
            {
                Console.WriteLine(string.Join(" ", secondNature));
            }
            else
            {
                Console.WriteLine("None");
            }

        }
    }
}
