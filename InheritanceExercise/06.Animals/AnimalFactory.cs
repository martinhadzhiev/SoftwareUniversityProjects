namespace _06.Animals
{
    using System;
    using Models;

    public static class AnimalFactory
    {
        public static Animal ProduceAnimal(string type, string name, int age, string gender)
        {
            switch (type)
            {
                case "Cat":
                    return new Cat(name, age, gender);
                case "Dog":
                    return new Dog(name, age, gender);
                case "Frog":
                    return new Frog(name, age, gender);
                case "Kitten":
                    return new Kitten(name, age, gender);
                case "Tomcat":
                    return new Tomcat(name, age, gender);
                default:
                    throw new ArgumentException("Invalid input!");
            }

            return null;
        }
    }
}
