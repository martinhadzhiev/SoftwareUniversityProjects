﻿namespace _01.Person
{
    using System;

    public class Person
    {
        protected string name;
        protected int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        protected virtual int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }

                this.age = value;
            }
        }



        private string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age} ";
        }
    }
}