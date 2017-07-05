namespace CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {

            var n = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                var engineTokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (engineTokens.Length)
                {
                    case 2:
                        var engine = new Engine(engineTokens[0],
                            int.Parse(engineTokens[1]));
                        engines.Add(engine);
                        break;
                    case 3:
                        try
                        {
                            engine = new Engine(engineTokens[0],
                                int.Parse(engineTokens[1]),
                                int.Parse(engineTokens[2]));
                        }
                        catch (Exception)
                        {
                            engine = new Engine(engineTokens[0],
                                int.Parse(engineTokens[1]),
                                engineTokens[2]);
                        }
                        engines.Add(engine);
                        break;
                    case 4:
                        engine = new Engine(engineTokens[0],
                            int.Parse(engineTokens[1]),
                            int.Parse(engineTokens[2]),
                            engineTokens[3]);
                        engines.Add(engine);
                        break;
                }
            }

            var m = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                var carTokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (carTokens.Length)
                {
                    case 2:
                        var e = engines.FirstOrDefault(en => en.model == carTokens[1]);
                        var car = new Car(carTokens[0], e);
                        cars.Add(car);
                        break;
                    case 3:
                        e = engines.FirstOrDefault(en => en.model == carTokens[1]);
                        try
                        {
                            car = new Car(carTokens[0], e, int.Parse(carTokens[2]));
                        }
                        catch (Exception)
                        {
                            car = new Car(carTokens[0], e, carTokens[2]);
                        }
                        cars.Add(car);
                        break;
                    case 4:
                        e = engines.FirstOrDefault(en => en.model == carTokens[1]);
                        car = new Car(carTokens[0], e, int.Parse(carTokens[2]), carTokens[3]);
                        cars.Add(car);
                        break;
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
