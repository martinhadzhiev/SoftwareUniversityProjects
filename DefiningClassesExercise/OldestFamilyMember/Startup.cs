using System;
using System.Linq;
using System.Reflection;

class Startup
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var family = new Family();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split();
            var name = line[0];
            var age = int.Parse(line[1]);

            Person p = new Person();
            p.name = name;
            p.age = age;

            family.AddMember(p);
        }

        family.people
            .Where(p => p.age > 30)
            .OrderBy(p => p.name)
            .ToList()
            .ForEach(p => Console.WriteLine($"{p.name} - {p.age}"));
    }
}

