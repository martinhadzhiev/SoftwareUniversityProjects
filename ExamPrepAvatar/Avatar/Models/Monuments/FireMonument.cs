public class FireMonument : Monument
{
    private int fireAffinity;

    public FireMonument(string name , int affinity)
        : base(name)
    {
        this.fireAffinity = affinity;
    }

    public override int GetPower()
    {
        return this.fireAffinity;
    }

    public override string ToString()
    {
        return $"Fire {base.ToString()}, Fire Affinity: {fireAffinity}";
    }
}