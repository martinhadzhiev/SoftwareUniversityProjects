namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    using Animals;
    using Foods;

    class Startup
    {
        static void Main()
        {
            string line = Console.ReadLine();

            while (line != "End")
            {
                var animalInfo = line.Trim().Split();
                var foodInfo = Console.ReadLine().Trim().Split();

                Animal animal;

                if (animalInfo[0] == "Cat")
                {
                    animal = AnimalFactory.ProduceAnimal(animalInfo[0],
                    animalInfo[1],
                    double.Parse(animalInfo[2]),
                    animalInfo[3],
                    animalInfo[4]);

                    animal.makeSound();
                }
                else
                {
                    animal = AnimalFactory.ProduceAnimal(animalInfo[0],
                        animalInfo[1],
                        double.Parse(animalInfo[2]),
                        animalInfo[3]);
                    animal.makeSound();
                }

                Food food;

                if (foodInfo[0] == "Vegetable")
                {
                    food = new Vegetable(int.Parse(foodInfo[1]));
                    animal.eat(food);
                }
                else if (foodInfo[0] == "Meat")
                {
                    food = new Meat(int.Parse(foodInfo[1]));
                    animal.eat(food);
                }

                Console.WriteLine(animal);

                line = Console.ReadLine();
            }
        }
    }
}
