namespace WildFarm.Animals
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string type, string name, double weight, string livingRegion)
            : base(type, name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        protected string LivingRegion
        {
            get { return this.livingRegion; }
            private set { this.livingRegion = value; }
        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
