using System;

public class Car
{
    public string model;
    public double fuelAmount;
    public double fuelConsumption;
    public double distanceTraveled;

    public Car(string model , double fuel , double consumption)
    {
        this.model = model;
        this.fuelAmount = fuel;
        this.fuelConsumption = consumption;
        this.distanceTraveled = 0;
    }

    public void MoveCar(double distance)
    {
        if (distance*this.fuelConsumption > this.fuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
            return;
        }

        this.distanceTraveled += distance;
        this.fuelAmount -= distance * this.fuelConsumption;
    }
}