using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability) 
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.addOns = new List<string>();
    }

    public override string ToString()
    {
        var result = new StringBuilder(base.ToString());
        if (this.addOns.Count == 0)
        {
            result.AppendLine($"Add-ons: None");
        }
        else
        {
            result.AppendLine($"Add-ons: {string.Join(", ",this.addOns)}");
        }

        return result.ToString().Trim();
    }
}