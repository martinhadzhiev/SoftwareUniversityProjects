namespace WildFarm.Animals
{
    using System;
    using Foods;

    public class Zebra : Mammal
    {
        public Zebra(string type, string name, double weight, string livingRegion)
            : base(type, name, weight, livingRegion)
        {
        }

        public override void makeSound()
        {
            Console.WriteLine("Zs");
        }

        public override void eat(Food food)
        {
            if (food is Vegetable)
            {
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine("Zebras are not eating that type of food!");
            }
        }
    }
}
