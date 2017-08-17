using System.Collections.Generic;

public class QuitCommand : Command
{
    public QuitCommand(IList<string> arguments, IManager manager)
        : base(manager, arguments)
    {
    }

    public override string Execute()
    {
        return this.Manager.Quit();
    }
}