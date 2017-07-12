public class EarthBender : Bender
{
    private double groundSaturation;

    public EarthBender(string name, int power, double secondaryElement)
        : base(name, power)
    {
        this.groundSaturation = secondaryElement;
    }

    public override double GetPower()
    {
        return base.GetPower() * groundSaturation;
    }

    public override string ToString()
    {
        return $"Earth {base.ToString()}, Ground Saturation: {groundSaturation:F2}";
    }
}