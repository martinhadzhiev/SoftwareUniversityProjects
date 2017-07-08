namespace _06.Animals
{
    using System;
    using System.Collections.Generic;
    using Models;

    class Startup
    {
        static void Main()
        {
            var animals = new List<Animal>();
            var type = Console.ReadLine().Trim();

            while (type != "Beast!")
            {
                try
                {
                    var animalTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (animalTokens.Length != 3) throw new ArgumentException("Invalid input!");

                    var animal = AnimalFactory
                        .ProduceAnimal(type,
                        animalTokens[0],
                        int.Parse(animalTokens[1]),
                        animalTokens[2]);

                    if (animal != null)
                    {
                        animals.Add(animal);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                type = Console.ReadLine().Trim();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name}");
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
