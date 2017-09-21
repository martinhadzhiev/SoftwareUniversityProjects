using System;
using System.Collections.Generic;
using System.Linq;

public class InspectCommand : Command
{
    private readonly IHarvesterController harvesterController;
    private readonly IProviderController providerController;

    public InspectCommand(IList<string> arguments, IHarvesterController harvesterController,
        IProviderController providerController)
        : base(arguments)
    {
        this.harvesterController = harvesterController;
        this.providerController = providerController;
    }

    public override string Execute()
    {
        int entityId = int.Parse(this.Arguments[0]);

        ICollection<IEntity> entities = new List<IEntity>();

        foreach (IEntity entity in this.harvesterController.Entities)
        {
            entities.Add(entity);
        }

        foreach (IEntity entity in this.providerController.Entities)
        {
            entities.Add(entity);
        }

        if (entities.Any(e => e.ID == entityId))
        {
            return entities.FirstOrDefault(e => e.ID == entityId).ToString();
        }

        return $"No entity found with id - {entityId}";
    }
}