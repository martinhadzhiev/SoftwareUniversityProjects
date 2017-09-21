using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var peopleCount = int.Parse(Console.ReadLine());

        SortedSet<Person> peopleSorted = new SortedSet<Person>();
        HashSet<Person> peopleHased = new HashSet<Person>();

        for (int i = 0; i < peopleCount; i++)
        {
            var personArgs = Console.ReadLine().Split();

            peopleSorted.Add(new Person(personArgs[0], int.Parse(personArgs[1])));
            peopleHased.Add(new Person(personArgs[0], int.Parse(personArgs[1])));
        }

        Console.WriteLine(peopleSorted.Count);
        Console.WriteLine(peopleHased.Count);
    }
}