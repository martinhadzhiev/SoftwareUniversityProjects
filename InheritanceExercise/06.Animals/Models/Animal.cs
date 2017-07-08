namespace _06.Animals.Models
{
    using System;

    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Gender
        {
            get { return this.gender; }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }

        public abstract string ProduceSound();
    }
}
