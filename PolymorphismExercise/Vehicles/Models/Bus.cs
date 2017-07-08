namespace Vehicles.Models
{
    using System;

    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override void DriveVehicle(double km)
        {
            if (km * (this.FuelConsumption + 1.4) <= this.FuelQuantity)
            {
                Console.WriteLine($"Bus travelled {km} km");
                this.FuelQuantity -= km * (this.FuelConsumption + 1.4);
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
            }
        }

        public void DriveEmpty(double km)
        {
            if (km * this.FuelConsumption <= this.FuelQuantity)
            {
                Console.WriteLine($"Bus travelled {km} km");
                this.FuelQuantity -= km * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
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
