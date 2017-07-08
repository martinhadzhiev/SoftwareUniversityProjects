namespace Vehicles.Models
{
    using System;

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += 1.6;
        }

        public override void DriveVehicle(double km)
        {
            if (km * this.FuelConsumption <= this.FuelQuantity)
            {
                Console.WriteLine($"Truck travelled {km} km");
                this.FuelQuantity -= km * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }

        public override void RefuelVehicle(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                this.FuelQuantity += fuel * 0.95;
            }
        }
    }
}
