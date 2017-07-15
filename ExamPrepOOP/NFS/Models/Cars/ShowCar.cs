using System.Text;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.stars = 0;
    }

    public override string ToString()
    {
        var result = new StringBuilder(base.ToString());
        result.AppendLine($"{stars} *");

        return result.ToString().Trim();
    }
}