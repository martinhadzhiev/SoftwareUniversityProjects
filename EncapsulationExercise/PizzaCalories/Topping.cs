namespace PizzaCalories
{
    using System;

    public class Topping
    {
        private string type;
        private int weight;
        private int maxWeight = 50;
        private int minWeight = 1;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        private int Weight
        {
            get { return this.weight; }
            set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        private string Type
        {
            get { return this.type; }
            set
            {
                if (!value.ToLower().Equals("meat")
                    && !value.ToLower().Equals("veggies")
                    && !value.ToLower().Equals("cheese")
                    && !value.ToLower().Equals("sauce"))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public double GetCalories()
        {
            double result = 2;
            result *= weight;

            switch (Type.ToLower())
            {
                case "meat":
                    result *= 1.2;
                    break;
                case "veggies":
                    result *= 0.8;
                    break;
                case "cheese":
                    result *= 1.1;
                    break;
                case "sauce":
                    result *= 0.9;
                    break;

            }
            return result;
        }
    }
}
