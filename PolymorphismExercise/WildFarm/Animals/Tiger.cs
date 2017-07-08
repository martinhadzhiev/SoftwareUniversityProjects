namespace WildFarm.Animals
{
    using System;
    using Foods;

    public class Tiger : Felime
    {
        public Tiger(string type, string name, double weight, string livingRegion)
            : base(type, name, weight, livingRegion)
        {
        }

        public override void makeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void eat(Food food)
        {
            if (food is Meat)
            {
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine("Tigers are not eating that type of food!");
            }
        }
    }
}
