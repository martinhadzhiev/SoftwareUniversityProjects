public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power, double secondaryElement)
        : base(name, power)
    {
        this.heatAggression = secondaryElement;
    }

    public override double GetPower()
    {
        return base.GetPower() * heatAggression;
    }

    public override string ToString()
    {
        return $"Fire {base.ToString()}, Heat Aggression: {heatAggression:F2}";
    }
}