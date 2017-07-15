using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private static Dictionary<int, Car> cars = new Dictionary<int, Car>();
    private static Dictionary<int, Race> races = new Dictionary<int, Race>();
    Garage garage = new Garage();

    public void Register(int id, string type, string brand, string model,
        int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        CarFactory factory = new CarFactory();
        var car = factory.ProduceCar(type, brand, model, yearOfProduction,
            horsepower, acceleration, suspension, durability);

        cars[id] = car;
    }

    public string Check(int id)
    {
        return cars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        RaceFactory factory = new RaceFactory();
        var race = factory.ProduceRace(type, length, route, prizePool);
        races[id] = race;
    }

    public void Participate(int carId, int raceId)
    {
        var car = cars[carId];
        races[raceId].AddParticipant(carId, car);
    }

    public string Start(int id)
    {
        return races[id].ToString();
    }

    public void Park(int id)
    {
        bool isParticipantInRace = races.Values.Any(r => r.ContainsParticipant(id));

        if (!isParticipantInRace)
        {
            garage.Park(id, cars[id]);
        }
    }

    public void Unpark(int id)
    {
        garage.Unpark(id);
    }

    public void Tune(int tuneIndex, string addOn)
    {

    }

}