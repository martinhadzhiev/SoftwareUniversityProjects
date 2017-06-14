using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    using System;

    class PopulationCounter
    {
        static void Main()
        {
            var input = Console.ReadLine().Split('|');
            var countries = new Dictionary<string,SortedDictionary<string,long>>();

            while (input[0] != "report")
            {
                var country = input[1];
                var town = input[0];
                var population = long.Parse(input[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country,new SortedDictionary<string, long>(){{town,population}});
                }
                else
                {
                    countries[country].Add(town,population);
                }

                input = Console.ReadLine().Split('|');
            }

            foreach (KeyValuePair<string, SortedDictionary<string, long>> country in countries.OrderByDescending( co => co.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(v => v.Value)})");

                foreach (var town in country.Value.OrderByDescending(t => t.Value))
                {
                    Console.WriteLine($"=>{town.Key}: {town.Value}");
                }

            }

            
        }
    }
}
