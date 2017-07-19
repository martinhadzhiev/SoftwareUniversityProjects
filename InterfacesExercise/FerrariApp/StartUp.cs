using System;

class StartUp
{
    static void Main()
    {
        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }

        ICar ferrari = new Ferrari(Console.ReadLine());
        Console.WriteLine(ferrari);
    }
}