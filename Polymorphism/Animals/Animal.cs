public abstract class Animal
{
    private string name;
    private string favouriteFood;

    public Animal(string name , string favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }

    public string FavouriteFood
    {
        get { return this.favouriteFood; }
        set { this.favouriteFood = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public abstract string ExplainMyself();
}