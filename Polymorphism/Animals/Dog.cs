public class Dog : Animal
{
    public Dog(string name, string favfouriteFood)
        : base(name, favfouriteFood)
    {
       
    }

    public override string ExplainMyself()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}\r\nDJAAF";
    }
}