public abstract class Monument
{
    private string name;

    public Monument(string name)
    {
        this.name = name;
    }

    public abstract int GetPower();

    public override string ToString()
    {
        return $"Monument: {name}";
    }
}