using System.Collections.Generic;

public class RepairCommand : Command
{
    private readonly IProviderController providerController;

    public RepairCommand(IList<string> arguments, IProviderController providerController)
        : base(arguments)
    {
        this.providerController = providerController;
    }

    public override string Execute()
    {
        double val = double.Parse(this.Arguments[0]);

        return this.providerController.Repair(val);
    }
}