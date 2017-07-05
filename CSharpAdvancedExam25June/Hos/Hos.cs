using System.Linq;

namespace Hos
{
    using System;
    using System.Collections.Generic;

    class Hos
    {
        private static Dictionary<string, List<string>> departmentsPatients =
            new Dictionary<string, List<string>>();
        private static Dictionary<string, Dictionary<int, List<string>>> departmentRooms =
            new Dictionary<string, Dictionary<int, List<string>>>();
        private static Dictionary<string, List<string>> doctorsPatients =
            new Dictionary<string, List<string>>();

        static void Main()
        {

            var input = Console.ReadLine();

            while (input != "Output")
            {
                var inputArgs = input.Trim().Split();
                var dep = inputArgs[0];
                var doc = string.Concat(inputArgs[1], " ", inputArgs[2]);
                var pat = inputArgs[3];

                InsertIntoDepPat(dep, pat);
                InsertIntoDepRooms(dep, pat);
                InsertIntoDocPat(doc, pat);

                input = Console.ReadLine();
            }

            var line = Console.ReadLine().Trim();

            while (line != "End")
            {
                var args = line.Split();

                if (departmentsPatients.ContainsKey(line) && args.Length == 1)
                {
                    foreach (var keyValuePair in departmentsPatients.Where(d => d.Key == line))
                    {
                        Console.WriteLine(string.Join("\n\r", keyValuePair.Value));
                    }
                }
                else if (args.Length == 2 && doctorsPatients.ContainsKey(line))
                {
                    foreach (var doctorsPatient in doctorsPatients.Where(d => d.Key == line))
                    {
                        Console.WriteLine(string.Join("\n\r", doctorsPatient.Value.OrderBy(p => p)));
                    }
                }
                else if (args.Length == 2 && departmentRooms.ContainsKey(args[0]))
                {
                    var dep = args[0];
                    var room = int.Parse(args[1]);

                    foreach (var kvp in departmentRooms.Where(d => d.Key == dep))
                    {
                        foreach (var rp in kvp.Value.Where(r => r.Key == room))
                        {
                            Console.WriteLine(string.Join("\n\r", rp.Value.OrderBy(a => a)));
                        }
                    }
                }

                line = Console.ReadLine();
            }
        }

        private static void InsertIntoDocPat(string doc, string pat)
        {
            if (!doctorsPatients.ContainsKey(doc))
            {
                doctorsPatients.Add(doc, new List<string>());
                doctorsPatients[doc].Add(pat);
            }
            else
            {
                doctorsPatients[doc].Add(pat);
            }
        }

        private static void InsertIntoDepRooms(string dep, string pat)
        {
            if (!departmentRooms.ContainsKey(dep))
            {
                departmentRooms.Add(dep, new Dictionary<int, List<string>>());

                for (int i = 1; i <= 20; i++)
                {
                    departmentRooms[dep].Add(i,new List<string>());
                }
                departmentRooms[dep][1] = new List<string>() { pat };
            }
            else
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (departmentRooms[dep][i].Count < 3)
                    {
                        departmentRooms[dep][i].Add(pat);
                        break;
                    }
                }

            }
        }

        private static void InsertIntoDepPat(string dep, string pat)
        {
            if (!departmentsPatients.ContainsKey(dep))
            {
                departmentsPatients.Add(dep, new List<string>());
                departmentsPatients[dep].Add(pat);
            }
            else
            {
                departmentsPatients[dep].Add(pat);
            }
        }
    }
}
