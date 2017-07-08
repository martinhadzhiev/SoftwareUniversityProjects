namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        

        public Vehicle(double fuelQuantity , double fuelConsumption , double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        protected double TankCapacity
        {
            get { return this.tankCapacity; }
            set { this.tankCapacity = value; }
        }

        protected double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        protected double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public abstract void DriveVehicle(double km);

        public abstract void RefuelVehicle(double fuel);

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
