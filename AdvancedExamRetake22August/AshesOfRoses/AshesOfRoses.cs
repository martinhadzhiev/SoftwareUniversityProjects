using System.Linq;

namespace AshesOfRoses
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    class AshesOfRoses
    {
        private static Dictionary<string, Dictionary<string, long>> regions = new Dictionary<string, Dictionary<string, long>>();

        static void Main()
        {
            string line;
            var regex = new Regex("^Grow <([A-Z]{1}[a-z]*)> <([A-Za-z0-9]*)> ([0-9]+)$");

            while ((line = Console.ReadLine()) != "Icarus, Ignite!")
            {
                var match = regex.Match(line);

                if (match.Success)
                {
                    var region = match.Groups[1].Value;
                    var color = match.Groups[2].Value;
                    var count = long.Parse(match.Groups[3].Value);

                    EnterRegion(region, color, count);
                }
            }
            PrintResult();
        }

        private static void PrintResult()
        {
            foreach (var region in regions.OrderByDescending(r => r.Value.Values.Sum()).ThenBy(r => r.Key))
            {
                Console.WriteLine($"{region.Key}");

                foreach (var color in region.Value.OrderBy(c => c.Value).ThenBy(c => c.Key))
                {
                    Console.WriteLine($"*--{color.Key} | {color.Value}");
                }
            }
        }

        private static void EnterRegion(string region, string color, long count)
        {
            if (regions.ContainsKey(region))
            {
                if (regions[region].ContainsKey(color))
                {
                    regions[region][color] += count;
                }
                else
                {
                    regions[region].Add(color,count);
                }
            }
            else
            {
                regions.Add(region, new Dictionary<string, long>(){{color,count}});
            }
        }
    }
}
