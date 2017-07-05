using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main()
    {
        var carCount = int.Parse(Console.ReadLine());
        var cars = new List<Car>();

        for (int i = 0; i < carCount; i++)
        {
            var carArgs = Console.ReadLine().Trim().Split();
            var model = carArgs[0];
            var fuel = double.Parse(carArgs[1]);
            var consumption = double.Parse(carArgs[2]);

            if (cars.All(c => c.model != model))
            {
                var car = new Car(model, fuel, consumption);
                cars.Add(car);
            }
        }

        string cmd;

        while ((cmd = Console.ReadLine()) != "End")
        {
            var cmdArgs = cmd.Trim().Split();
            var model = cmdArgs[1];
            var distance = double.Parse(cmdArgs[2]);

            if (cars.FirstOrDefault(c => c.model == model) != null)
            {
                var car = cars.FirstOrDefault(c => c.model == model);
                car.MoveCar(distance);
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.model} {car.fuelAmount:F2} {car.distanceTraveled}");
        }
    }
}