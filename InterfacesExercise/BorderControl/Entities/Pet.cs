public class Pet : IIdentifiable
{
    public string Name { get; private set; }
    public string Birthdate { get; private set; }

    public Pet(string name , string birthdate)
    {
        this.Name = name;
        this.Birthdate = birthdate;
    }
}