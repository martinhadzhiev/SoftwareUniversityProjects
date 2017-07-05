using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main()
    {
        var cars = new List<Car>();
        var carCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < carCount; i++)
        {
            var carArgs = Console.ReadLine().Trim().Split();
            var model = carArgs[0];
            var engSpeed = int.Parse(carArgs[1]);
            var engPower = int.Parse(carArgs[2]);
            var cargoW = int.Parse(carArgs[3]);
            var cargoType = carArgs[4];
            var t1p = double.Parse(carArgs[5]);
            var t1a = int.Parse(carArgs[6]);
            var t2p = double.Parse(carArgs[7]);
            var t2a = int.Parse(carArgs[8]);
            var t3p = double.Parse(carArgs[9]);
            var t3a = int.Parse(carArgs[10]);
            var t4p = double.Parse(carArgs[11]);
            var t4a = int.Parse(carArgs[12]);

            Tyre t1 = new Tyre(){age = t1a,pressure = t1p};
            Tyre t2 = new Tyre(){age = t2a,pressure = t2p};
            Tyre t3 = new Tyre(){age = t3a,pressure = t3p};
            Tyre t4 = new Tyre(){age = t4a,pressure = t4p};

            Tyre[] tires = new Tyre[4]{t1,t2,t3,t4};
            Engine engine = new Engine(){power = engPower,speed = engSpeed};
            Cargo cargo = new Cargo(){type = cargoType,weight = cargoW};

            Car car = new Car(model,engine,cargo,tires);

            cars.Add(car);
        }

        var cmd = Console.ReadLine();

        if (cmd.Equals("fragile"))
        {
            var result = cars.Where(c => c.cargo.type == "fragile" && c.Tyres.Any(t => t.pressure < 1)).ToList();

            result.ForEach(c => Console.WriteLine($"{c.model}"));
        }
        else
        {
            var result = cars.Where(c => c.cargo.type == "flamable" && c.engine.power > 250).ToList();

            result.ForEach(c => Console.WriteLine($"{c.model}"));
        }
    }
}