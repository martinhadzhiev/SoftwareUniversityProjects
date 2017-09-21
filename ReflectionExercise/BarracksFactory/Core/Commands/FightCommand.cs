namespace BarracksFactory.Core.Commands
{
    using System;
    using Contracts;

    public class FightCommand : IExecutable
    {
        public string Execute()
        {
            Environment.Exit(0);

            return "";
        }
    }
}
