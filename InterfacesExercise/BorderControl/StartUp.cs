using System;
using System.Collections;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {
        ICollection<IIdentifiable> petsAndPeople = new List<IIdentifiable>();

        var command = Console.ReadLine();

        while (command != "End")
        {
            var cmdArgs = command.Trim().Split();
            var cmd = cmdArgs[0];

            switch (cmd)
            {
                case "Citizen":
                    petsAndPeople.Add(new Citizen(cmdArgs[1],int.Parse(cmdArgs[2]),cmdArgs[3],cmdArgs[4]));
                    break;
                case "Pet":
                    petsAndPeople.Add(new Pet(cmdArgs[1],cmdArgs[2]));
                    break;
            }

            command = Console.ReadLine();
        }

        var yearToCkeck = Console.ReadLine();

        foreach (var obj in petsAndPeople)
        {
            if (obj.Birthdate.EndsWith(yearToCkeck))
            {
                Console.WriteLine(obj.Birthdate);
            }
        }
    }
}