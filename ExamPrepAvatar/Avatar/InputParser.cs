using System;
using System.Linq;

public class InputParser
{
    public void Run()
    {
        NationsBuilder builder = new NationsBuilder();

        string command;

        while (true)
        {
            command = Console.ReadLine();
            var commandArgs = command.Trim().Split().ToList();

            switch (commandArgs[0])
            {
                case "Bender":
                    builder.AssignBender(commandArgs.Skip(1).ToList());
                    break;
                case "Monument":
                    builder.AssignMonument(commandArgs.Skip(1).ToList());
                    break;
                case "Status":
                    var result = builder.GetStatus(commandArgs[1]);
                    Console.WriteLine($"{commandArgs[1]} Nation");
                    Console.WriteLine(result);
                    break;
                case "War":
                    builder.IssueWar(commandArgs[1]);
                    break;
                case "Quit":
                    result = builder.GetWarsRecord();
                    Console.WriteLine(result);
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
