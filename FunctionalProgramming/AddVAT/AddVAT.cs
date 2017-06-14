﻿namespace AddVAT
{
    using System;
    using System.Linq;

    class AddVAT
    {
        static void Main()
        {
            Console.ReadLine()
                .Split(new []{", "},StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n *=1.2)
                .ToList()
                .ForEach(n => Console.WriteLine($"{n:F2}"));
        }
    }
}
