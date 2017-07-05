namespace FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Startup
    {
        static void Main()
        {
            var people = new List<Person>();
            var commands = new List<string>();
            var searchedPerson = Console.ReadLine();

            var line = Console.ReadLine();

            while (line != "End")
            {
                commands.Add(line);
                line = Console.ReadLine();
            }

            foreach (var cmd in commands.Where(c => !c.Contains("-")))
            {
                var tokens = cmd.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = string.Concat(tokens[0], " ", tokens[1]);
                var birthDate = tokens[2];

                var person = new Person() { name = name, birthday = birthDate };
                people.Add(person);
            }

            foreach (var cmd in commands.Where(c => c.Contains("-")))
            {
                var tokens = cmd.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                var parent = people.FirstOrDefault(p => p.birthday == tokens[0] || p.name == tokens[0]);
                people.First(c => c.birthday == tokens[1] || c.name == tokens[1]).parents.Add(parent);
            }

            var personToPrint = people.FirstOrDefault(p => p.name == searchedPerson || p.birthday == searchedPerson);

            PrintResult(people, personToPrint);

        }

        private static void PrintResult(List<Person> people, Person personToPrint)
        {
            Console.WriteLine($"{personToPrint.name} {personToPrint.birthday}");
            Console.WriteLine("Parents:");
            foreach (var parent in personToPrint.parents)
            {
                Console.WriteLine($"{parent.name} {parent.birthday}");
            }
            Console.WriteLine("Children:");
            foreach (var person in people.Where(p => p.parents.Contains(personToPrint)))
            {
                Console.WriteLine($"{person.name} {person.birthday}");
            }
        }
    }
}
