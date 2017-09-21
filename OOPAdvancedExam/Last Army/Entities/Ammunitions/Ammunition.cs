public abstract class Ammunition : IAmmunition
{
    protected Ammunition(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
        this.WearLevel = this.Weight * 100;
    }

    public string Name { get; private set; }

    public double Weight { get; private set; }

    public double WearLevel { get; private set; }

    public void DecreaseWearLevel(double wearAmount)
    {
        this.WearLevel -= wearAmount;
    }
}
