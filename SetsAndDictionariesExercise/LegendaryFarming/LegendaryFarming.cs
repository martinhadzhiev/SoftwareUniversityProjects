using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace LegendaryFarming
{
    using System;

    class LegendaryFarming
    {
        static void Main()
        {
            var input = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var inventory = new SortedDictionary<string, int>();
            inventory.Add("shards", 0);
            inventory.Add("motes", 0);
            inventory.Add("fragments", 0);
            var legendaryInventory = new Dictionary<string,int>();

            while (inventory["fragments"] < 250 || inventory["shards"] < 250 || inventory["motes"] < 250)
            {
                for (int i = 0; i < input.Length; i += 2)
                {
                    if (inventory.ContainsKey(input[i + 1]))
                    {
                        inventory[input[i + 1]] += int.Parse(input[i]);
                    }
                    else
                    {
                        inventory[input[i + 1]] = int.Parse(input[i]);
                    }
                    PrintCraftedItem(inventory,legendaryInventory);
                }
                input = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }




        }

        private static void PrintCraftedItem(SortedDictionary<string, int> inventory,Dictionary<string,int> legendaryInventory)
        {
            if (inventory["shards"] >= 250)
            {
                inventory["shards"] -= 250;
                legendaryInventory.Add("shards",inventory["shards"]);
                inventory.Remove("shards");
                legendaryInventory.Add("motes",inventory["motes"]);
                inventory.Remove("motes");
                legendaryInventory.Add("fragments", inventory["fragments"]);
                inventory.Remove("fragments");

                Console.WriteLine("Shadowmourne obtained!");
                foreach (var item in legendaryInventory.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                foreach (var item in inventory.OrderBy(i => i.Key))
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                Environment.Exit(0);
            }
            else if (inventory["motes"]>= 250)
            {
                inventory["motes"] -= 250;
                legendaryInventory.Add("motes", inventory["motes"]);
                inventory.Remove("motes");
                legendaryInventory.Add("shards", inventory["shards"]);
                inventory.Remove("shards");
                legendaryInventory.Add("fragments", inventory["fragments"]);
                inventory.Remove("fragments");

                Console.WriteLine("Dragonwrath obtained!");
                foreach (var item in legendaryInventory.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                foreach (var item in inventory.OrderBy(i => i.Key))
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                Environment.Exit(0);
            }
            else if (inventory["fragments"] >= 250)
            {
                inventory["fragments"] -= 250;
                legendaryInventory.Add("fragments", inventory["fragments"]);
                inventory.Remove("fragments");
                legendaryInventory.Add("motes", inventory["motes"]);
                inventory.Remove("motes");
                legendaryInventory.Add("shards", inventory["shards"]);
                inventory.Remove("shards");

                Console.WriteLine("Valanyr obtained!");
                foreach (var item in legendaryInventory.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                foreach (var item in inventory.OrderBy(i => i.Key))
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                Environment.Exit(0);
            }
        }
    }
}
