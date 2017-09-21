using System.Collections.Generic;
using System.Text;

public class ShutdownCommand : Command
{
    private readonly IHarvesterController harvesterController;
    private readonly IProviderController providerController;

    public ShutdownCommand(IList<string> arguments, IHarvesterController harvesterController,
        IProviderController providerController)
        : base(arguments)
    {
        this.harvesterController = harvesterController;
        this.providerController = providerController;
    }

    public override string Execute()
    {
        StringBuilder commandMessage = new StringBuilder();

        commandMessage.AppendLine("System Shutdown");
        commandMessage.AppendLine($"Total Energy Produced: {this.providerController.TotalEnergyProduced}");
        commandMessage.AppendLine($"Total Mined Plumbus Ore: {this.harvesterController.OreProduced}");

        return commandMessage.ToString().Trim();
    }
}