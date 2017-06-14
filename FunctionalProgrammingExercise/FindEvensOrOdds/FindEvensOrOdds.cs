namespace FindEvensOrOdds
{
    using System;
    using System.Linq;

    class FindEvensOrOdds
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var condition = Console.ReadLine();


            Predicate<int> isOdd = n => n % 2 != 0;

            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                if (condition == "odd" && isOdd(i))
                {
                    Console.Write(i + " ");
                }
                else if (!isOdd(i) && condition == "even")
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
