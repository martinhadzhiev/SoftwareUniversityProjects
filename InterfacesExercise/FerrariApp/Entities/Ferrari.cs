public class Ferrari : ICar
{
    public string Model { get; }
    public string Driver { get; }

    public Ferrari(string driver)
    {
        this.Model = "488-Spider";
        this.Driver = driver;
    }

    public string Brake()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brake()}/{this.Gas()}/{this.Driver}";
    }
}