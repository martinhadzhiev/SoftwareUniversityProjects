namespace WildFarm.Animals
{
    using System;
    using Foods;

    public class Mouse : Mammal
    {
        public Mouse(string type, string name, double weight, string livingRegion)
            : base(type, name, weight, livingRegion)
        {
        }

        public override void makeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }

        public override void eat(Food food)
        {
            if (food is Vegetable)
            {
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine("Mouses are not eating that type of food!");
            }
        }
    }
}
