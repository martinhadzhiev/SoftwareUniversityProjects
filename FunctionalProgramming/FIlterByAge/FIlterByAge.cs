namespace FIlterByAge
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class FIlterByAge
    {
        static void Main()
        {
            var personCount = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, int>();

            for (int i = 0; i < personCount; i++)
            {
                var personArgs = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var name = personArgs[0];
                var age = int.Parse(personArgs[1]);

                dictionary.Add(name, age);
            }

            var condition = Console.ReadLine();
            var conditionAge = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            switch (condition)
            {
                case "younger":
                    if (format == "name")
                    {
                        foreach (var p in dictionary.Where(p => p.Value < conditionAge))
                        {
                            Console.WriteLine(p.Key);
                        }
                    }
                    else if (format == "age")
                    {
                        foreach (var p in dictionary.Where(p => p.Value < conditionAge))
                        {
                            Console.WriteLine(p.Value);
                        }
                    }
                    else if (format == "name age")
                    {
                        foreach (var p in dictionary.Where(p => p.Value < conditionAge))
                        {
                            Console.WriteLine($"{p.Key} - {p.Value}");
                        }
                    }
                    break;

                case "older":
                    if (format == "name")
                    {
                        foreach (var p in dictionary.Where(p => p.Value >= conditionAge).OrderBy(p => p.Value))
                        {
                            Console.WriteLine(p.Key);
                        }
                    }
                    else if (format == "age")
                    {
                        foreach (var p in dictionary.Where(p => p.Value >= conditionAge).OrderBy(p => p.Value))
                        {
                            Console.WriteLine(p.Value);
                        }
                    }
                    else if (format == "name age")
                    {
                        foreach (var p in dictionary.Where(p => p.Value >= conditionAge).OrderBy(p => p.Value))
                        {
                            Console.WriteLine($"{p.Key} - {p.Value}");
                        }
                    }
                    break;

            }

        }
    }
}
