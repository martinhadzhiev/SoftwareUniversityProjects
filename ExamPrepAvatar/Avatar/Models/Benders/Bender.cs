public abstract class Bender
{
    private string name;
    private int power;

    public Bender(string name, int power)
    {
        this.name = name;
        this.power = power;
    }

    public virtual double GetPower()
    {
        return this.power;
    }

    public override string ToString()
    {
        return $"Bender: {name}, Power: {power}";
    }
}