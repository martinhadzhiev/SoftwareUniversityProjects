using System;
class Startup
{
    static void Main()
    {
        var startDate = Console.ReadLine();
        var endDate = Console.ReadLine();

        var result = DateModifier.ModifyDate(startDate, endDate);

        Console.WriteLine(Math.Abs(result));
    }
}