using System;
using System.Collections.Generic;
using System.Linq;

public class Engine : IEngine
{
    private const string TerminatingCommand = "Shutdown";

    private readonly IWriter writer;
    private readonly IReader reader;
    private readonly ICommandInterpreter commandInterpreter;

    public Engine(ICommandInterpreter commandInterpreter)
    {
        this.writer = new Writer();
        this.reader = new Reader();
        this.commandInterpreter = commandInterpreter;
    }

    public void Run()
    {
        while (true)
        {
            string input = this.reader.ReadLine().Trim();
            List<string> arguments = input.Split().ToList();

            string commandMessage = this.commandInterpreter.ProcessCommand(arguments);

            this.writer.WriteLine(commandMessage);

            if (input.Equals(TerminatingCommand,StringComparison.OrdinalIgnoreCase))
            {
                Environment.Exit(0);
            }
        }
    }
}
