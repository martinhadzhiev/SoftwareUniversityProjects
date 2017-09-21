using System.Collections.Generic;

public class ItemCommand : Command
{
    public ItemCommand(IList<string> arguments, IManager manager)
        : base(manager, arguments)
    {
    }

    public override string Execute()
    {
        return this.Manager.AddItem(this.Arguments);
    }
}