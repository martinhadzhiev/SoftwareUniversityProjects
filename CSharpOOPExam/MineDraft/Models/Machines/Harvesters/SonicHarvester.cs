using System.Text;

public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
        : base(id, oreOutput, energyRequirement)
    {
        this.sonicFactor = sonicFactor;
        this.EnergyRequirement /= this.sonicFactor;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Sonic Harvester - {base.Id}");
        sb.AppendLine($"Ore Output: {base.OreOutput}");
        sb.AppendLine($"Energy Requirement: {base.EnergyRequirement}");

        return sb.ToString().Trim();
    }
}