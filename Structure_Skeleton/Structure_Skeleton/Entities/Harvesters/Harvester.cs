using System.Text;

public abstract class Harvester : IHarvester
{
    private const int InitialDurability = 1000;
    private const int BreakValue = 100;

    protected Harvester(int id, double oreOutput, double energyRequirement)
    {
        this.ID = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
        this.Durability = InitialDurability;
    }

    public int ID { get; }

    public double OreOutput { get; protected set; }

    public double EnergyRequirement { get; protected set; }

    public virtual double Durability { get; protected set; }

    public double Produce()
    {
        return this.OreOutput;
    }

    public void Broke()
    {
        this.Durability -= BreakValue;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        result.AppendLine($"{this.GetType().Name}");
        result.AppendLine($"Durability: {this.Durability}");

        return result.ToString().Trim();
    }
}