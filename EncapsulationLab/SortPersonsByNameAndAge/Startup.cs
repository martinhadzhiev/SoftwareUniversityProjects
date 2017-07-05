using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    public static void Main()
    {
        var lineCount = int.Parse(Console.ReadLine());
        var people = new List<Person>();

        for (int i = 0; i < lineCount; i++)
        {
            var lineArgs = Console.ReadLine().Trim().Split();
            var fName = lineArgs[0];
            var lName = lineArgs[1];
            var age = int.Parse(lineArgs[2]);
            var salary = double.Parse(lineArgs[3]); 

            var person = new Person(fName,lName,age,salary);
            people.Add(person);
        }

        var team = new Team("Gorno nanadolnishte");

        foreach (var person in people)
        {
            team.AddPlayer(person);
        }

        Console.WriteLine(team.ToString());
    }
}

