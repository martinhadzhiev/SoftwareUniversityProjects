using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        IList<Person> people = new List<Person>();
        var line = Console.ReadLine();

        while (line != "END")
        {
            var personArgs = line.Split();

            people.Add(new Person(personArgs[0], int.Parse(personArgs[1]), personArgs[2]));

            line = Console.ReadLine();
        }

        int personForComparison = int.Parse(Console.ReadLine());

        if (people.Count <= personForComparison)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            int equalPeople = 0;
            int notEqualPeople = 0;

            Person p = people[personForComparison];

            foreach (var person in people)
            {
                if (p.CompareTo(person) == 0)
                {
                    equalPeople++;
                }
                else
                {
                    notEqualPeople++;
                }
            }
            if (equalPeople == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeople} {notEqualPeople} {people.Count}");
            }
        }
    }
}