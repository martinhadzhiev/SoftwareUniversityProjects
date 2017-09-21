namespace InfernoInfinity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandParser
    {
        private readonly CommandManager manager;

        public CommandParser(CommandManager manager)
        {
            this.manager = manager;
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                IList<string> commandArgs = command.Split(';').ToList();

                switch (commandArgs[0])
                {
                    case "Create":
                        manager.CreateWeaponCommand(commandArgs.Skip(1).ToList());
                        break;

                    case "Add":
                        manager.AddGemToWeaponCommand(commandArgs.Skip(1).ToList());
                        break;

                    case "Remove":
                        manager.RemoveGemFromWeapon(commandArgs.Skip(1).ToList());
                        break;

                    case "Print":
                        manager.PrintWeaponInfo(commandArgs.Skip(1).ToList());
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
