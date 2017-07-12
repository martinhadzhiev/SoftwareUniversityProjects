public class WaterMonument : Monument
{
    private int waterAffinity;

    public WaterMonument(string name , int affinity) 
        : base(name)
    {
        this.waterAffinity = affinity;
    }

    public override int GetPower()
    {
        return this.waterAffinity;
    }

    public override string ToString()
    {
        return $"Water {base.ToString()}, Water Affinity: {waterAffinity}";
    }
}