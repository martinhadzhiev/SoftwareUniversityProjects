namespace GroupByGroup
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class GroupByGroup
    {
        static void Main()
        {
            var groups = new List<Person>();
            var line = Console.ReadLine();

            while (line != "END")
            {
                var lineArgs = line.Trim().Split();
                var names = string.Concat(lineArgs[0], " ", lineArgs[1]);
                var group = int.Parse(lineArgs[2]);

                var person = new Person(names,group);
                groups.Add(person);

                line = Console.ReadLine();
            }

            foreach (var person in groups.GroupBy(p => p.Group).OrderBy(p => p.Key))
            {
                Console.WriteLine($"{person.Key} - {string.Join(", ",groups.Where(p => p.Group == person.Key).Select(p => p.Name))}");
            }
        }
    }

}
