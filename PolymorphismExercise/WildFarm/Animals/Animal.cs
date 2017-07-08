namespace WildFarm.Animals
{
    using Foods;

    public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        public Animal(string type, string name , double weight)
        {
            this.AnimalType = type;
            this.AnimalName = name;
            this.AnimalWeight = weight;
        }

        protected int FoodEaten
        {
            get { return this.foodEaten; }
            set { this.foodEaten = value; }
        }

        protected double AnimalWeight
        {
            get { return this.animalWeight; }
            private set { this.animalWeight = value; }
        }

        protected string AnimalType
        {
            get { return this.animalType; }
            private set { this.animalType = value; }
        }

        protected string AnimalName
        {
            get { return this.animalName; }
            private set { this.animalName = value; }
        }

        public abstract void makeSound();
        public abstract void eat(Food food);

    }
}
