public class WaterBender : Bender
{
    private double waterClarity;

    public WaterBender(string name, int power, double secondaryElement)
        : base(name, power)
    {
        this.waterClarity = secondaryElement;
    }

    public override double GetPower()
    {
        return base.GetPower() * waterClarity;
    }

    public override string ToString()
    {
        return $"Water {base.ToString()}, Water Clarity: {waterClarity:F2}";
    }
}