using System;

public class StartUp
{
    static void Main()
    {
        Scale<string> stringScale = new Scale<string>("a", "c");
        Console.WriteLine(stringScale.GetHavier());

        Scale<int> intScale = new Scale<int>(1, 2);
        Console.WriteLine(intScale.GetHavier());
    }
}