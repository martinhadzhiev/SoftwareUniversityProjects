namespace Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var people = new List<Person>();

            while (!line.Equals("End"))
            {
                var tokens = line.Trim().Split();
                var p = new Person(tokens[0]);
                if (people.All(pe => pe.name != tokens[0]))
                {
                    people.Add(p);
                }

                var command = tokens[1];

                switch (command)
                {
                    case "company":
                        var company = new Company()
                        {
                            name = tokens[2],
                            department = tokens[3],
                            salary = decimal.Parse(tokens[4])
                        };
                        people.FirstOrDefault(pr => pr.name == tokens[0]).company = company;

                        break;
                    case "car":
                        var car = new Car() { model = tokens[2], speed = tokens[3] };
                        people.FirstOrDefault(pr => pr.name == tokens[0]).car = car;
                        break;
                    case "pokemon":
                        var pokemon = new Pokemon() { name = tokens[2], type = tokens[3] };
                        people.FirstOrDefault(pr => pr.name == tokens[0]).pokemons.Add(pokemon);
                        break;
                    case "parents":
                        var parent = new Parent() { name = tokens[2], birthday = tokens[3] };
                        people.FirstOrDefault(pr => pr.name == tokens[0]).parents.Add(parent);
                        break;
                    case "children":
                        var child = new Child() { name = tokens[2], birthday = tokens[3] };
                        people.FirstOrDefault(pr => pr.name == tokens[0]).children.Add(child);
                        break;
                }

                line = Console.ReadLine();
            }

            var personName = Console.ReadLine();

            PrintResult(people, personName);
        }

        private static void PrintResult(List<Person> people, string personName)
        {
            var person = people.FirstOrDefault(p => p.name == personName);

            Console.WriteLine($"{personName}");
            Console.WriteLine("Company:");
            if (person.company != null)
            {
                Console.WriteLine($"{person.company.name} {person.company.department} {person.company.salary:F2}");
            }
            Console.WriteLine("Car:");
            if (person.car != null)
            {
                Console.WriteLine($"{person.car.model} {person.car.speed}");
            }
            Console.WriteLine("Pokemon:");
            foreach (var pok in person.pokemons)
            {
                Console.WriteLine($"{pok.name} {pok.type}");
            }
            Console.WriteLine("Parents:");
            foreach (var parent in person.parents)
            {
                Console.WriteLine($"{parent.name} {parent.birthday}");
            }
            Console.WriteLine("Children:");
            foreach (var child in person.children)
            {
                Console.WriteLine($"{child.name} {child.birthday}");
            }
        }
    }
}
