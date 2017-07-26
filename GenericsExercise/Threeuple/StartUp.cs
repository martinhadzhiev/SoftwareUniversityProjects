namespace Threeuple
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var firstLine = Console.ReadLine().Split();
            var secondLine = Console.ReadLine().Trim().Split();
            var thirdLine = Console.ReadLine().Split();

            bool drinkOrNot = secondLine[2].ToLower() == "drunk";

            var nameAddressTown =
                new Threeuple<string, string, string>
                (string.Concat(firstLine[0] + " " + firstLine[1]), firstLine[2], firstLine[3]);
            var nameBeerDrunk = new Threeuple<string, int, bool>(secondLine[0],
                int.Parse(secondLine[1]), drinkOrNot);
            var nameBalanceBankName =
                new Threeuple<string, double, string>(thirdLine[0], double.Parse(thirdLine[1]), thirdLine[2]);

            Console.WriteLine(nameAddressTown);
            Console.WriteLine(nameBeerDrunk);
            Console.WriteLine(nameBalanceBankName);

        }
    }
}
