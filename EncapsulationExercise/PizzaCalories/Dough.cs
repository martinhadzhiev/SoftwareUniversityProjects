namespace PizzaCalories
{
    using System;

    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;
        private int maxWeight = 200;
        private int minWeight = 1;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        private int Weight
        {
            get { return this.weight; }
            set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        private string BakingTechnique
        {
            get { return this.bakingTechnique; }
            set
            {
                if (!value.ToLower().Equals("crispy") &&
                    !value.ToLower().Equals("chewy") &&
                    !value.ToLower().Equals("homemade")
                    )
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        private string FlourType
        {
            get { return this.flourType; }
            set
            {
                if (!value.ToLower().Equals("white") && !value.ToLower().Equals("wholegrain"))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public double GetCalories()
        {
            double result = 2.0;
            result *= weight;

            switch (FlourType.ToLower())
            {
                case "white":
                    result *= 1.5;
                    break;
                case "wholegrain":
                    result *= 1.0;
                    break;
            }

            switch (BakingTechnique.ToLower())
            {
                case "crispy":
                    result *= 0.9;
                    break;
                case "chewy":
                    result *= 1.1;
                    break;
                case "homemade":
                    result *= 1.0;
                    break;
            }
            return result;
        }

    }
}
