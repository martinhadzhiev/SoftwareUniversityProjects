using System;
using System.Collections.Generic;

public class GameController
{
    private IDictionary<string, IArmy> army;
    private readonly IWareHouse wareHouse;
    private MissionController missionController;

    public GameController(IWareHouse wareHouse, MissionController missionController)
    {
        this.Army = new Dictionary<string, IArmy>();
        this.wareHouse = wareHouse;
        this.MissionController = missionController;
    }

    public IDictionary<string, IArmy> Army
    {
        get { return this.army; }
        private set { this.army = value; }
    }

    public IWareHouse WareHouse
    {
        get { return this.wareHouse; }
    }

    public MissionController MissionController
    {
        get { return this.missionController; }
        private set { this.missionController = value; }
    }

    //public string RequestResult()
    //{
    //   // return Output.GiveOutput(result, army, wearHouse, this.MissionControllerField.MissionQueue.Count);
    //}

    public void AddAmmunitions(IAmmunition ammunition, int count)
    {
        for (int i = 0; i < count; i++)
        {
            this.wareHouse.AddAmmunition(ammunition);
        }
    }

    public void AddSoldierToArmy(ISoldier soldier, string type)
    {
        if (!this.Army.ContainsKey(type))
        {
            this.Army[type] = new Army();
        }
        this.Army[type].AddSoldier(soldier);
    }
}