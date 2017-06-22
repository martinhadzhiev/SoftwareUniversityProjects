using System.Collections.Generic;
using System.Linq;

namespace MapDistricts
{
    using System;

    class MapDistricts
    {
        static void Main()
        {
            var line = Console.ReadLine().Split(new []{' ','\t','\n','\r'},StringSplitOptions.RemoveEmptyEntries);
            var minPopulation = long.Parse(Console.ReadLine());

            var cities = new Dictionary<string, List<long>>();

            foreach (var town in line)
            {
                var townArgs = town.Split(':');
                var name = townArgs[0];
                var population = long.Parse(townArgs[1]);

                if (cities.ContainsKey(name))
                {
                    cities[name].Add(population);
                }
                else
                {
                    cities.Add(name, new List<long>());
                    cities[name].Add(population);
                }
            }

            foreach (var city in cities.Where(c => c.Value.Sum() > minPopulation).OrderByDescending(c => c.Value.Sum()))
            {
                Console.WriteLine($"{city.Key}: {string.Join(" ",city.Value.OrderByDescending(p => p).Take(5))}");
            }
        }
    }
}
