using System;
using System.Text;

public class Provider : IProvider
{
    private const int InitialDurability = 1000;
    private const int BreakValue = 100;

    protected Provider(int id, double energyOutput)
    {
        this.ID = id;
        this.Durability = InitialDurability;
        this.EnergyOutput = energyOutput;
    }

    public int ID { get; private set; }
    public double Durability { get; protected set; }
    public double EnergyOutput { get; protected set; }

    public double Produce()
    {
        return this.EnergyOutput;
    }

    public void Broke()
    {
        this.Durability -= BreakValue;

        if (this.Durability < 0)
        {
            throw new Exception();
        }
    }

    public void Repair(double val)
    {
        this.Durability += val;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        result.AppendLine($"{this.GetType().Name}");
        result.AppendLine($"Durability: {this.Durability}");

        return result.ToString().Trim();
    }
}