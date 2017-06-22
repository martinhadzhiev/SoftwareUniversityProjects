using System.Collections.Generic;
using System.Linq;

namespace OfficeStuff
{
    using System;

    class OfficeStuff
    {
        static void Main()
        {
            var companies = new Dictionary<string, Dictionary<string, int>>();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' ', '-', '|' }, StringSplitOptions.RemoveEmptyEntries);
                var company = line[0];
                var amount = int.Parse(line[1]);
                var product = line[2];

                if (companies.ContainsKey(company))
                {
                    if (companies[company].ContainsKey(product))
                    {
                        companies[company][product] += amount;
                    }
                    else
                    {
                        companies[company].Add(product, amount);
                    }
                }
                else
                {
                    companies.Add(company, new Dictionary<string, int>());
                    companies[company].Add(product, amount);
                }
            }

            foreach (var company in companies.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{company.Key}: {string.Join(", ", company.Value.Select(pa => new {pName = pa.Key, pAmount = pa.Value}).Select(x => $"{x.pName}-{x.pAmount}"))}");
            }
        }
    }
}
