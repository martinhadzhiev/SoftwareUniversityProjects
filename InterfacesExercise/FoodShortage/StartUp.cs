using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var numberOfBuyers = int.Parse(Console.ReadLine());

        ICollection<IPerson> buyers = new List<IPerson>();

        for (int i = 0; i < numberOfBuyers; i++)
        {
            var buyerInfo = Console.ReadLine().Trim().Split();

            if (buyerInfo.Length == 4)
            {
                buyers.Add(new Citizen(buyerInfo[0], int.Parse(buyerInfo[1]), buyerInfo[2], buyerInfo[3]));
            }
            else
            {
                buyers.Add(new Rebel(buyerInfo[0], int.Parse(buyerInfo[1]), buyerInfo[2]));
            }
        }

        var buyerName = Console.ReadLine().Trim();

        while (buyerName != "End")
        {
            if (buyers.Any(b => b.Name == buyerName))
            {
                buyers.First(b => b.Name == buyerName).BuyFood();
            }

            buyerName = Console.ReadLine();
        }

        Console.WriteLine(buyers.Sum(b => b.Food));
    }
}