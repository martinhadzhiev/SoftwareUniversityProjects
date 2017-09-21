namespace PetClinics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Repository repository = new Repository();
            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                IList<string> commandArgs = Console.ReadLine().Split().ToList();
                string commandType = commandArgs[0];
                commandArgs.RemoveAt(0);

                switch (commandType)
                {
                    case "Create":
                        repository.CreateEnitity(commandArgs);
                        break;
                    case "Add":
                        repository.AddPetToClinic(commandArgs);
                        break;
                    case "Release":
                        repository.ReleasePet(commandArgs);
                        break;
                    case "HasEmptyRooms":
                        repository.CheckEmptyRooms(commandArgs);
                        break;
                    case "Print":
                        repository.PrintClinicInfo(commandArgs);
                        break;
                }
            }
        }
    }
}
