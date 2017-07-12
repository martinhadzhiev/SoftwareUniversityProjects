public class AirBender : Bender
{
    private double aerialIntegrity;

    public AirBender(string name, int power, double secondaryElement)
        : base(name, power)
    {
        this.aerialIntegrity = secondaryElement;
    }

    public override double GetPower()
    {
        return base.GetPower() * aerialIntegrity;
    }

    public override string ToString()
    {
        return $"Air {base.ToString()}, Aerial Integrity: {aerialIntegrity:F2}";
    }
}