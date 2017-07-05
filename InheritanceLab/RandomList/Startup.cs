using System;

class Startup
{
    static void Main()
    {
        RandomList rl = new RandomList(){"pesho","gosho","asen"};

        Console.WriteLine(rl.RandomString());
    }
}