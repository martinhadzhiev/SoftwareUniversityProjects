using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    using System;

    class DragonArmy
    {
        static void Main()
        {
            var dragonTypes = new Dictionary<string, SortedDictionary<string, int[]>>();
            int n = int.Parse(Console.ReadLine());

            int[] defaultStats = new int[] { 45, 250, 10 };

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var dragonType = line[0];
                var dragonName = line[1];

                line = line.Skip(2).ToArray();

                int[] stats = new int[3];

                for (int j = 0; j < 3; j++)
                {
                    if (line[j] == "null")
                    {
                        stats[j] = defaultStats[j];
                    }
                    else
                    {
                        stats[j] = int.Parse(line[j]);
                    }
                }

                if (!dragonTypes.ContainsKey(dragonType))
                {
                    dragonTypes.Add(dragonType, new SortedDictionary<string, int[]>() { { dragonName, stats } });
                }
                else if (dragonTypes[dragonType].ContainsKey(dragonName))
                {
                    dragonTypes[dragonType][dragonName] = stats;
                }
                else
                {
                    dragonTypes[dragonType].Add(dragonName, stats);
                }

            }

            foreach (var dragonType in dragonTypes)
            {
                double averageDamage = 0;
                double averageHealth = 0;
                double averageArmor = 0;

                foreach (var stat in dragonType.Value)
                {
                    averageDamage += stat.Value[0];
                    averageHealth += stat.Value[1];
                    averageArmor += stat.Value[2];
                }


                averageDamage /= dragonType.Value.Count;
                averageHealth /= dragonType.Value.Count;
                averageArmor /= dragonType.Value.Count;

                Console.WriteLine($"{dragonType.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");

                foreach (var dragon in dragonType.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
