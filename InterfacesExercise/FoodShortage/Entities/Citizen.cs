public class Citizen : IPerson
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    private string Id { get; set; }
    private string Birthdate { get; set; }
    public int Food { get; private set; }

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
        this.Food = 0;
    }

    public void BuyFood()
    {
        this.Food += 10;
    }
}