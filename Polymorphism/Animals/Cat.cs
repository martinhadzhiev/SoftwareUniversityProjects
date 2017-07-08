public class Cat : Animal
{
    public Cat(string name, string favfouriteFood)
        :base(name , favfouriteFood)
    {

    }

    public override string ExplainMyself()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}\r\nMEEOW";
    }
}