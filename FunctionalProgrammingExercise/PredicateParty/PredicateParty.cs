using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    using System;

    class PredicateParty
    {
        static void Main()
        {
            var guests = Console.ReadLine().Split().ToList();
            var line = Console.ReadLine();


            while (line != "Party!")
            {
                var lineArgs = line.Split();
                var command = lineArgs[0];
                var criteria = lineArgs[1];
                var condition = lineArgs[2];

                switch (command)
                {
                    case "Remove":
                        if (criteria == "StartsWith")
                        {
                            guests.RemoveAll(g => g.StartsWith(condition));
                        }
                        else if (criteria == "EndsWith")
                        {
                            guests.RemoveAll(g => g.EndsWith(condition));
                        }
                        else
                        {
                            guests.RemoveAll(g => g.Length == int.Parse(condition));
                        }
                        break;

                    case "Double":
                        if (criteria == "StartsWith")
                        {
                            guests.AddRange(guests.Where(g => g.StartsWith(condition)));
                        }
                        else if (criteria == "EndsWith")
                        {

                        }
                        else
                        {

                        }
                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",guests)+" are going!");

        }
    }
}
