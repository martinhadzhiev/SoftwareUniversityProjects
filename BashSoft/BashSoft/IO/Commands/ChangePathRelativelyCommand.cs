﻿namespace BashSoft.IO.Commands
{
    using System.Diagnostics;
    using Exceptions;

    public class ChangePathRelativelyCommand : Command
    {
        public ChangePathRelativelyCommand(string input, string[] data, Tester judge, StudentRepository repository, IOManager inputOutputManager)
            : base(input, data, judge, repository, inputOutputManager)
        {

        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            var relPath = this.Data[1];
            this.InputOutputManager.ChangeCurrentDirectoryRelative(relPath);
        }
    }
}
