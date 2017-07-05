namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> cart;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.cart = new List<Product>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        private decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            if (product.Price > this.money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }

            this.cart.Add(product);
            this.money -= product.Price;
        }

        public IList<Product> GetProducts()
        {
            return this.cart.AsReadOnly();
        }
    }
}
