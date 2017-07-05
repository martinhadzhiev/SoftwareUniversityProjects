namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public double GetCalories()
        {
            double result = 0.0;

            result += this.dough.GetCalories();
            foreach (var topping in this.toppings)
            {
                result += topping.GetCalories();
            }
            return result;
        }
    }
}
