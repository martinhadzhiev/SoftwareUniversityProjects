using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    public void Run()
    {
        DraftManager manager = new DraftManager();

        while (true)
        {
            var commandArgs = Console.ReadLine().Split().ToList();
            var cmd = commandArgs[0];

            ParseCommand(commandArgs, cmd, manager);
        }
    }

    private static void ParseCommand(List<string> commandArgs, string cmd, DraftManager manager)
    {
        switch (cmd)
        {
            case "RegisterHarvester":
                Console.WriteLine(manager.RegisterHarvester(commandArgs.Skip(1).ToList()));
                break;
            case "RegisterProvider":
                Console.WriteLine(manager.RegisterProvider(commandArgs.Skip(1).ToList()));
                break;
            case "Day":
                Console.WriteLine(manager.Day());
                break;
            case "Mode":
                Console.WriteLine(manager.Mode(commandArgs.Skip(1).ToList()));
                break;
            case "Check":
                Console.WriteLine(manager.Check(commandArgs.Skip(1).ToList()));
                break;
            case "Shutdown":
                Console.WriteLine(manager.ShutDown());
                Environment.Exit(0);
                break;
        }
    }
}