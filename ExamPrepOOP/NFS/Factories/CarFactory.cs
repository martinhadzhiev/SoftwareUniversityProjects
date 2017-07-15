﻿public class CarFactory
{
    public Car ProduceCar(string type, string brand, string model,
        int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        switch (type)
        {
            case "Performance":
                return new PerformanceCar(brand, model, yearOfProduction,
                    horsepower, acceleration, suspension, durability);

            case "Show":
                return new ShowCar(brand, model, yearOfProduction,
                    horsepower, acceleration, suspension, durability);
        }

        return null;
    }
}