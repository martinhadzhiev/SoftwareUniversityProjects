using System.Collections.Generic;
using System.Linq;

public class RegisterCommand : Command
{
    private readonly IHarvesterController harvesterController;
    private readonly IProviderController providerController;

    public RegisterCommand(IList<string> arguments, IHarvesterController harvesterController,
        IProviderController providerController)
        : base(arguments)
    {
        this.harvesterController = harvesterController;
        this.providerController = providerController;
    }

    public override string Execute()
    {
        if (this.Arguments[0] == "Harvester")
        {
            return this.harvesterController.Register(this.Arguments.Skip(1).ToList());
        }
        else
        {
            return this.providerController.Register(this.Arguments.Skip(1).ToList());
        }
    }
}