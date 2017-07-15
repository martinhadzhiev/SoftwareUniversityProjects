using System.Collections.Generic;

public class Garage
{
    private Dictionary<int, Car> parkedCars;

    public Garage()
    {
        this.parkedCars = new Dictionary<int, Car>();
    }

    public void Park(int id, Car car)
    {
        this.parkedCars[id] = car;
    }

    public void Unpark(int id)
    {
        if (this.parkedCars.ContainsKey(id))
        {
            this.parkedCars.Remove(id);
        }
    }
}