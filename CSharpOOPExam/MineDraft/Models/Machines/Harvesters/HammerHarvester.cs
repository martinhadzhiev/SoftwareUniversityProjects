using System.Text;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput += oreOutput * 2;
        this.EnergyRequirement += energyRequirement;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Hammer Harvester - {base.Id}");
        sb.AppendLine($"Ore Output: {base.OreOutput}");
        sb.AppendLine($"Energy Requirement: {base.EnergyRequirement}");

        return sb.ToString().Trim();
    }
}