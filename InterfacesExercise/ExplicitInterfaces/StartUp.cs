using System;

public class StartUp
{
    static void Main()
    {
        var people = Console.ReadLine();

        while (people != "End")
        {
            var personInfo = people.Trim().Split();

            IPerson person = new Citizen(personInfo[0], personInfo[1], int.Parse(personInfo[2]));
            IResident resident = new Citizen(personInfo[0], personInfo[1], int.Parse(personInfo[2]));

            person.GetName();
            resident.GetName();

            people = Console.ReadLine();
        }
    }
}