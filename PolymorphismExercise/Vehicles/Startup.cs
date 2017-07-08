namespace Vehicles
{
    using System;
    using Models;

    class Startup
    {
        static void Main()
        {
            var carInfo = Console.ReadLine().Trim().Split();
            var truckInfo = Console.ReadLine().Trim().Split();
            var busInfo = Console.ReadLine().Trim().Split();
            var lineCount = int.Parse(Console.ReadLine());

            Car car = new Car(double.Parse(carInfo[1]),
                double.Parse(carInfo[2]),
                double.Parse(carInfo[3]));
            Truck truck = new Truck(double.Parse(truckInfo[1]),
                double.Parse(truckInfo[2]),
                double.Parse(truckInfo[3]));
            Bus bus = new Bus(double.Parse(busInfo[1]),
                double.Parse(busInfo[2]),
                double.Parse(busInfo[3]));

            for (int i = 0; i < lineCount; i++)
            {
                var command = Console.ReadLine().Trim().Split();

                if (command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        car.DriveVehicle(double.Parse(command[2]));
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.DriveVehicle(double.Parse(command[2]));
                    }
                    else if (command[1] == "Bus")
                    {
                        bus.DriveVehicle(double.Parse(command[2]));
                    }
                }
                else if (command[0] == "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        car.RefuelVehicle(double.Parse(command[2]));
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.RefuelVehicle(double.Parse(command[2]));
                    }
                    else if (command[1] == "Bus")
                    {
                        bus.RefuelVehicle(double.Parse(command[2]));
                    }
                }
                else if (command[0] == "DriveEmpty")
                {
                    bus.DriveEmpty(double.Parse(command[2]));
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
