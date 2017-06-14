namespace CustomMinFunction
{
    using System;
    using System.Linq;
    
    class CustomMinFunction
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> minFunc = ints => ints.OrderBy(n => n).First();

            Console.WriteLine(minFunc(numbers));
        }
    }
}
