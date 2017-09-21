using System.Collections.Generic;
using System.Linq;

public class HarvesterController : IHarvesterController
{
    private const string InitialMode = "Full";
    private const int InitialWorkPercentage = 1;

    private List<IHarvester> harvesters;
    private IEnergyRepository energyRepository;
    private IHarvesterFactory factory;
    private string mode;
    private double workPercentage;

    public HarvesterController(IEnergyRepository energyRepository)
    {
        this.harvesters = new List<IHarvester>();
        this.energyRepository = energyRepository;
        this.factory = new HarvesterFactory();
        this.mode = InitialMode;
        this.workPercentage = InitialWorkPercentage;
    }

    public double OreProduced { get; private set; }

    public IReadOnlyCollection<IEntity> Entities => this.harvesters.AsReadOnly();

    public string Register(IList<string> args)
    {
        var harvester = this.factory.GenerateHarvester(args);
        this.harvesters.Add(harvester);
        return string.Format(Constants.SuccessfullRegistration,
            harvester.GetType().Name);
    }

    public string Produce()
    {
        double energyNeeded = this.harvesters.Sum(h => h.EnergyRequirement) * this.workPercentage;
        double oreMined = 0;

        if (this.energyRepository.TakeEnergy(energyNeeded))
        {
            oreMined = this.harvesters.Sum(h => h.Produce()) * this.workPercentage;

            this.OreProduced += oreMined;
        }

        return string.Format(Constants.OreOutputToday, oreMined);
    }

    public string ChangeMode(string mode)
    {
        this.mode = mode;

        switch (mode)
        {
            case "Energy":
                this.workPercentage = 0.2;
                break;
            case "Half":
                this.workPercentage = 0.5;
                break;
            case "Full":
                this.workPercentage = 1;
                break;
        }

        foreach (IHarvester harvester in this.harvesters)
        {
            harvester.Broke();
        }

        this.RemoveBrokenEntities();

        return string.Format(Constants.ModeChanged, mode);
    }

    private void RemoveBrokenEntities()
    {
        List<IHarvester> harvestersToRemove = this.harvesters.Where(h => h.Durability < 0).ToList();

        foreach (IHarvester harvester in harvestersToRemove)
        {
            this.harvesters.Remove(harvester);
        }
    }
}