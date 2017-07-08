namespace WildFarm.Animals
{
    using System;
    using Foods;

    public class Cat : Felime
    {
        private string breed;

        public Cat(string type, string name, double weight, string livingRegion, string breed)
            : base(type, name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        private string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public override void makeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
