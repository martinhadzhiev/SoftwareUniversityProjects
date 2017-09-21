using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        int peopleCount = int.Parse(Console.ReadLine());
        SortedSet<Person> peopleSortedByNames = new SortedSet<Person>(new NameLengthComparator());
        SortedSet<Person> peopleSortedByAge = new SortedSet<Person>(new AgeComparator());

        for (int i = 0; i < peopleCount; i++)
        {
            var personArgs = Console.ReadLine().Split();

            peopleSortedByNames.Add(new Person(personArgs[0], int.Parse(personArgs[1])));
            peopleSortedByAge.Add(new Person(personArgs[0], int.Parse(personArgs[1])));
        }

        foreach (var person in peopleSortedByNames)
        {
            Console.WriteLine(person);
        }

        foreach (var person in peopleSortedByAge)
        {
            Console.WriteLine(person);
        }
    }
}