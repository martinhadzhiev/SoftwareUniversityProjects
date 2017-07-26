using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        ICollection<ISoldier> soldiers = new List<ISoldier>();

        var soldierInfo = Console.ReadLine();

        while (soldierInfo != "End")
        {
            var soldierArgs = soldierInfo.Trim().Split();

            switch (soldierArgs[0])
            {
                case "Private":
                    soldiers.Add(new Private(int.Parse(
                        soldierArgs[1]), soldierArgs[2], soldierArgs[3], double.Parse(soldierArgs[4])));
                    break;

                case "LeutenantGeneral":
                    LeutenantGeneral leutinantGeneral = new LeutenantGeneral(int.Parse(
                        soldierArgs[1]), soldierArgs[2], soldierArgs[3], double.Parse(soldierArgs[4]));

                    for (int i = 5; i < soldierArgs.Length; i++)
                    {
                        leutinantGeneral.Privates.Add(soldiers.FirstOrDefault(s => s.Id == int.Parse(soldierArgs[i])));
                    }

                    soldiers.Add(leutinantGeneral);
                    break;

                case "Spy":
                    soldiers.Add(new Spy(int.Parse(soldierArgs[1]), soldierArgs[2], soldierArgs[3], int.Parse(soldierArgs[4])));
                    break;

                case "Engineer":
                    try
                    {
                        Engineer engineer = new Engineer(int.Parse(
                            soldierArgs[1]), soldierArgs[2], soldierArgs[3], double.Parse(soldierArgs[4]), soldierArgs[5]);

                        for (int i = 6; i < soldierArgs.Length - 1; i += 2)
                        {
                            engineer.Repairs.Add(new KeyValuePair<string, int>(soldierArgs[i], int.Parse(soldierArgs[i + 1])));
                        }

                        soldiers.Add(engineer);
                    }
                    catch (Exception e)
                    {

                    }
                    break;

                case "Commando":
                    try
                    {
                        Commando commando = new Commando(int.Parse(
                            soldierArgs[1]), soldierArgs[2], soldierArgs[3], double.Parse(soldierArgs[4]), soldierArgs[5]);

                        for (int i = 6; i < soldierArgs.Length - 1; i += 2)
                        {
                            try
                            {
                                commando.Missions.Add(new Mission(soldierArgs[i], soldierArgs[i + 1]));
                            }
                            catch (Exception)
                            {

                            }
                        }

                        soldiers.Add(commando);
                    }
                    catch (Exception)
                    {

                    }
                    break;
            }

            soldierInfo = Console.ReadLine();
        }

        foreach (var soldier in soldiers)
        {
            Console.WriteLine(soldier);
        }
    }
}