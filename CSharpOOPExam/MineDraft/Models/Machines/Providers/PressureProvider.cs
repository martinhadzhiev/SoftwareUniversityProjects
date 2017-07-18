using System.Text;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
        this.EnergyOutput += energyOutput * 0.5;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Pressure Provider - {base.Id}");
        sb.AppendLine($"Energy Output: {base.EnergyOutput}");

        return sb.ToString().Trim();
    }
}
