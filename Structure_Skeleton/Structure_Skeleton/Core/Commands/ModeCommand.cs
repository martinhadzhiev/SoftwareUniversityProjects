using System.Collections.Generic;

public class ModeCommand : Command
{
    private readonly IHarvesterController harvesterController;

    public ModeCommand(IList<string> arguments, IHarvesterController harvesterController)
        : base(arguments)
    {
        this.harvesterController = harvesterController;
    }

    public override string Execute()
    {
        string mode = this.Arguments[0];

        return this.harvesterController.ChangeMode(mode);
    }
}