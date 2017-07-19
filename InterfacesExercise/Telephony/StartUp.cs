using System;

public class StartUp
{
    static void Main()
    {
        Smartphone smartphone = new Smartphone();
        var numbers = Console.ReadLine().Trim().Split();
        var sites = Console.ReadLine().Trim().Split();

        foreach (var number in numbers)
        {
            Console.WriteLine(smartphone.Call(number));
        }

        foreach (var site in sites)
        {
            Console.WriteLine(smartphone.Browse(site));
        }
    }
}