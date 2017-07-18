using System.Text;

public class SolarProvider : Provider
{
    public SolarProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Solar Provider - {base.Id}");
        sb.AppendLine($"Energy Output: {base.EnergyOutput}");

        return sb.ToString().Trim();
    }
}