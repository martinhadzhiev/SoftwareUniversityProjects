﻿namespace BashSoft
{
    using System;
    using Contracts;

    public class InputReader : IReader
    {
        private const string endCommand = "quit";
        private readonly IInterpreter interpreter;

        public InputReader(IInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        public void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}" + "> ");
            string input = Console.ReadLine().Trim();

            while (input != endCommand)
            {
                this.interpreter.InterpretCommand(input);
                OutputWriter.WriteMessage($"{SessionData.currentPath}" + "> ");
                input = Console.ReadLine().Trim();
            }
        }
    }
}
