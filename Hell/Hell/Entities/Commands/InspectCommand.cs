﻿using System.Collections.Generic;

public class InspectCommand : Command
{
    public InspectCommand(IList<string> arguments, IManager manager)
        : base(manager, arguments)
    {
    }

    public override string Execute()
    {
        return this.Manager.Inspect(this.Arguments);
    }
}