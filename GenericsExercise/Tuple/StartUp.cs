namespace Tuple
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var line1 = Console.ReadLine().Split();
            var line2 = Console.ReadLine().Split();
            var line3 = Console.ReadLine().Split();

            var nameAndAddress = new Tuple<string, string>(string.Concat(line1[0] + " " + line1[1]), line1[2]);
            var nameAndBeer = new Tuple<string, int>(line2[0], int.Parse(line2[1]));
            var intDouble = new Tuple<int, double>(int.Parse(line3[0]), double.Parse(line3[1]));

            Console.WriteLine(nameAndAddress);
            Console.WriteLine(nameAndBeer);
            Console.WriteLine(intDouble);
        }
    }
}
