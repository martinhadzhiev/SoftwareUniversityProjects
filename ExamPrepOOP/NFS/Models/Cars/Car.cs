using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;

    public Car(string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsepower = horsepower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;
    }

    public string Brand
    {
        get { return this.brand; }
    }

    public string Model
    {
        get { return this.model; }
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"{this.brand} {this.model} {this.yearOfProduction}");
        result.AppendLine($"{horsepower} HP, 100 m/h in {acceleration} s");
        result.AppendLine($"{suspension} Suspension force, {durability} Durability");

        return result.ToString();
    }

    public int GetOverAllPerformance()
    {
        var result = 0;
        result = (this.horsepower / this.acceleration) + (this.suspension + this.durability);

        return result;
    }

    public int GetEnginePerformance()
    {
        var result = 0;
        result = (this.horsepower / this.acceleration);

        return result;
    }

    public int GetSuspensionPerformance()
    {
        var result = 0;
        result = (this.suspension + this.durability);

        return result;
    }
}
