namespace PoisonousPlants
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    class PoisonousPlants
    {
        static void Main()
        {
            int plantNumber = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var daysPlantsDie = new int[plantNumber];
            var previousPlants = new Stack<int>();

            previousPlants.Push(0);

            for (int i = 1; i < plantNumber; i++)
            {
                var lastDayDeath = 0;
                while (previousPlants.Count > 0 && plants[previousPlants.Peek()] >= plants[i])
                {
                    lastDayDeath = Math.Max(lastDayDeath, daysPlantsDie[previousPlants.Pop()]);
                }

                if (previousPlants.Count > 0)
                {
                    daysPlantsDie[i] = lastDayDeath + 1;
                }
                previousPlants.Push(i);
            }
            Console.WriteLine(daysPlantsDie.Max());
        }
    }
}
