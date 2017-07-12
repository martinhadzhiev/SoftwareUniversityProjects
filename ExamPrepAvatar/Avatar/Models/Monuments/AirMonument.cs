public class AirMonument : Monument
{
    private int airAffinity;

    public AirMonument(string name, int affinity)
        : base(name)
    {
        this.airAffinity = affinity;
    }

    public override int GetPower()
    {
        return this.airAffinity;
    }

    public override string ToString()
    {
        return $"Air {base.ToString()}, Air Affinity: {airAffinity}";
    }
}