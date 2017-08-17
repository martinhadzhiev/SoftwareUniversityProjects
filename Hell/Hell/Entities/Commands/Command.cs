using System.Collections.Generic;

public abstract class Command : ICommand
{
    private IManager manager;
    private IList<string> arguments;

    protected Command(IManager manager, IList<string> arguments)
    {
        this.Manager = manager;
        this.Arguments = arguments;
    }

    public IManager Manager
    {
        get { return this.manager; }
        private set { this.manager = value; }
    }

    protected IList<string> Arguments
    {
        get { return this.arguments; }
        private set { this.arguments = value; }
    }

    public abstract string Execute();
}