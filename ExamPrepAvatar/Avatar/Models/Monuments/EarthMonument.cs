public class EarthMonument : Monument
{
    private int earthAffinity;

    public EarthMonument(string name, int affinity)
        : base(name)
    {
        this.earthAffinity = affinity;
    }

    public override int GetPower()
    {
        return this.earthAffinity;
    }

    public override string ToString()
    {
        return $"Earth {base.ToString()}, Earth Affinity: {earthAffinity}";
    }
}