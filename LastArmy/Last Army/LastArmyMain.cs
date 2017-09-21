using System;
using System.Text;

class LastArmyMain
{
    static void Main()
    {
        IReader reader = new ConsoleReader(); ;
        IWriter writer = new ConsoleWriter();
        ISoldierFactory soldierFactory = new SoldierFactory();
        IAmmunitionFactory ammunitionFactory = new AmmunitionFactory();
        IMissionFactory missionFactory = new MissionFactory();
        IArmy army = new Army();
        IWareHouse wareHouse = new WareHouse();
        MissionController missionController = new MissionController(army, wareHouse);
        GameController gameController = new GameController(wareHouse,missionController);

        Engine engine = new Engine(reader, writer, soldierFactory, ammunitionFactory
            , missionFactory,gameController);
        engine.Run();
    }
}