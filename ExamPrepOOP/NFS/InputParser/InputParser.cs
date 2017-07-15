using System;

public class InputParser
{
    public void Read()
    {
        CarManager manager = new CarManager();

        while (true)
        {
            var cmdArgs = Console.ReadLine().Trim().Split();

            switch (cmdArgs[0])
            {
                case "register":
                    var carId = int.Parse(cmdArgs[1]);
                    var carType = cmdArgs[2];
                    var brand = cmdArgs[3];
                    var model = cmdArgs[4];
                    var yearOfProd = int.Parse(cmdArgs[5]);
                    var horsepower = int.Parse(cmdArgs[6]);
                    var acceleration = int.Parse(cmdArgs[7]);
                    var suspension = int.Parse(cmdArgs[8]);
                    var durability = int.Parse(cmdArgs[9]);

                    manager.Register(carId, carType, brand, model, yearOfProd,
                        horsepower, acceleration, suspension, durability);
                    break;

                case "check":
                    var result = manager.Check(int.Parse(cmdArgs[1]));
                    Console.WriteLine(result);
                    break;

                case "open":
                    var raceId = int.Parse(cmdArgs[1]);
                    var raceType = cmdArgs[2];
                    var length = int.Parse(cmdArgs[3]);
                    var route = cmdArgs[4];
                    var prizePool = int.Parse(cmdArgs[5]);

                    manager.Open(raceId, raceType, length, route, prizePool);
                    break;

                case "participate":
                    var participantId = int.Parse(cmdArgs[1]);
                    var participantRaceId = int.Parse(cmdArgs[2]);
                    manager.Participate(participantId, participantRaceId);
                    break;

                case "start":
                    var id = int.Parse(cmdArgs[1]);
                    var raceResult = manager.Start(id);

                    Console.WriteLine(raceResult);
                    break;

                case "park":
                    var parkId = int.Parse(cmdArgs[1]);
                    manager.Park(parkId);
                    break;

                case "unpark":
                    var unparkId = int.Parse(cmdArgs[1]);
                    manager.Unpark(unparkId);
                    break;
            }
        }
    }
}