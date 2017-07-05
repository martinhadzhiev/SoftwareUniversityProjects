using System.Collections.Generic;

public class Car
{
    public string model;
    public Engine engine;
    public Cargo cargo;
    public Tyre[] Tyres;

    public Car(string model, Engine engine, Cargo cargo, Tyre[] tyres)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.Tyres = tyres;
    }
}