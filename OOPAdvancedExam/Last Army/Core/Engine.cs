using System.Collections.Generic;
using System.Linq;

public class Engine : IEngine
{
    private readonly IReader reader;
    private readonly IWriter writer;
    private readonly ISoldierFactory soldierFactory;
    private readonly IAmmunitionFactory ammunitionFactory;
    private readonly IMissionFactory missionFactory;
    private readonly GameController gameController;

    public Engine(IReader reader, IWriter writer, ISoldierFactory soldierFactory, IAmmunitionFactory ammunitionFactory, IMissionFactory missionFactory, GameController gameController)
    {
        this.reader = reader;
        this.writer = writer;
        this.soldierFactory = soldierFactory;
        this.ammunitionFactory = ammunitionFactory;
        this.missionFactory = missionFactory;
        this.gameController = gameController;
    }

    public void Run()
    {
        bool isRunning = true;

        while (isRunning)
        {
            string commandLine = reader.ReadLine();
            List<string> commandArgs = commandLine.Split().ToList();

            string commandName = commandArgs[0];
            commandArgs.RemoveAt(0);

            switch (commandName)
            {
                case "WareHouse":
                    string ammunitionType = commandArgs[0];
                    int ammunitionCount = int.Parse(commandArgs[1]);

                    IAmmunition ammunition = this.ammunitionFactory.CreateAmmunition(ammunitionType);

                   // this.gameController.AddAmmunitions(ammunition, ammunitionCount);
                    break;

                case "Soldier":
                    if (commandArgs.Count == 5)
                    {
                        string soldierTypeName = commandArgs[0];
                        string name = commandArgs[1];

                        int age = int.Parse(commandArgs[2]);
                        double experience = int.Parse(commandArgs[3]);
                        double endurance = int.Parse(commandArgs[4]);

                        ISoldier soldier = this.soldierFactory
                            .CreateSoldier(soldierTypeName, name, age, experience, endurance);

                       // this.gameController.AddSoldierToArmy(soldier, soldierTypeName);
                    }
                    else if (commandArgs.Count == 2)
                    {
                        string regenerationType = commandArgs[1];

                        //this.gameController.Army[regenerationType].RegenerateTeam(regenerationType);
                    }
                    break;

                case "Mission":
                    string missionType = commandArgs[0];
                    double neededPoints = double.Parse(commandArgs[1]);

                    IMission mission = this.missionFactory.CreateMission(missionType, neededPoints);

                    //this.gameController.MissionController.PerformMission(mission);
                    break;
            }
            isRunning = this.isRunning(commandName);
        }
    }

    private bool isRunning(string command)
    {
        return command != "Enough! Pull back!";
    }
}