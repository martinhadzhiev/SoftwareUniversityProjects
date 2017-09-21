using System;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var rocks = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

        Lake lake = new Lake(rocks.Select(int.Parse).ToArray());

        Console.WriteLine(string.Join(", ",lake));
    }
}