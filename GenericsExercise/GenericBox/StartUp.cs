namespace GenericBox
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var list = new List<double>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }

            var element = double.Parse(Console.ReadLine());

            Console.WriteLine(Box<double>.CompareElements(list, element));
        }
    }
}
