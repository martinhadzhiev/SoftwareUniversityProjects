using System;
using System.Linq;
using System.Reflection;

class Startup
{
    static void Main()
    {
        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());

        var l = double.Parse(Console.ReadLine());
        var w = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());

        try
        {
            var box = new Box(l,w,h);
            box.GetAreaAndVolume();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}