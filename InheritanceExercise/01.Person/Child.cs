namespace _01.Person
{
    using System;

    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {

        }

        protected override int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }

                this.age = value;
            }
        }
    }
}
