namespace TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class TruckTour
    {
        static void Main()
        {
            int petrolStationsNum = int.Parse(Console.ReadLine());
            var petrolStations = new Queue<int[]>();

            for (int i = 0; i < petrolStationsNum; i++)
            {
                var petrolStation = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                petrolStations.Enqueue(petrolStation);
            }

            var reachFinal = false;
            var startingIndex = 0;
            while (!reachFinal)
            {
                var tank = 0;

                for (int i = 0; i <= petrolStationsNum; i++)
                {
                    if (i == petrolStationsNum)
                    {
                        reachFinal = true;
                        break;
                    }

                    var petrolStation = petrolStations.Dequeue();
                    petrolStations.Enqueue(petrolStation);

                    var liters = petrolStation[0];
                    var distanceToNext = petrolStation[1];

                    tank += liters - distanceToNext;

                    if (tank < 0)
                    {
                        startingIndex += i + 1;
                        break;
                    }
                }
            }
            Console.WriteLine(startingIndex);

        }
    }
}
