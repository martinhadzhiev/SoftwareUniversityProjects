using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;
    private double totalPower;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public double GetPower()
    {
        double result = 0;
        this.benders.ForEach(b => result += b.GetPower());
        int monumentSum = this.monuments.Sum(m => m.GetPower());

        result = result + (result / 100) * monumentSum;

        return result;
    }

    public List<Bender> Benders
    {
        get { return this.benders; }
    }
    public List<Monument> Monuments
    {
        get { return this.monuments; }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        if (benders.Count == 0)
        {
            sb.AppendLine("Benders: None");
        }
        else
        {
            sb.AppendLine("Benders:");
            foreach (var bender in benders)
            {
                sb.AppendLine($"###{bender.ToString()}");
            }
        }

        if (monuments.Count == 0)
        {
            sb.AppendLine("Monuments: None");
        }
        else
        {
            sb.AppendLine("Monuments:");
            foreach (var monument in monuments)
            {
                sb.AppendLine($"###{monument.ToString()}");
            }

        }
        return sb.ToString().Trim();
    }
}