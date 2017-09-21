using System.Collections.Generic;
using System.Text;

public class DayCommand : Command
{
    private IHarvesterController harvesterController;
    private IProviderController providerController;

    public DayCommand(IList<string> arguments, IHarvesterController harvesterController,
        IProviderController providerController)
        : base(arguments)
    {
        this.harvesterController = harvesterController;
        this.providerController = providerController;
    }

    public override string Execute()
    {
        StringBuilder commandMessage = new StringBuilder();

        commandMessage.AppendLine(this.providerController.Produce());
        commandMessage.AppendLine(this.harvesterController.Produce());

        return commandMessage.ToString().Trim();
    }
}