namespace Vehicles.Models
{
    using System;

    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption , tankCapacity)
        {
            this.FuelConsumption += 0.9;
        }

        public override void DriveVehicle(double km)
        {
            if (km * this.FuelConsumption <= this.FuelQuantity)
            {
                Console.WriteLine($"Car travelled {km} km");
                this.FuelQuantity -= km * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
            }
        }

        public override void RefuelVehicle(double fuel)
        {
            if (fuel > 0 && fuel <= this.TankCapacity - this.FuelQuantity)
            {
                this.FuelQuantity += fuel;
            }
            else if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
        }
    }
}
