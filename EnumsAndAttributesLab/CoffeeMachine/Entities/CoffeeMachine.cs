using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private int coinsInserted;

    public CoffeeMachine()
    {
        this.CoffeesSold = new List<CoffeeType>();
    }

    public IList<CoffeeType> CoffeesSold { get; }

    public void BuyCoffee(string size, string type)
    {
        var price = (int)Enum.Parse(typeof(CoffeePrice), size);

        var cofeeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);

        if (this.coinsInserted >= price)
        {
            this.CoffeesSold.Add(cofeeType);

            this.coinsInserted = 0;
        }
    }

    public void InsertCoin(string coin)
    {

        var insertingCoin = (int)Enum.Parse(typeof(Coin), coin);

        this.coinsInserted += insertingCoin;
    }
}