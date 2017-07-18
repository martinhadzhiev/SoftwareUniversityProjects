using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private List<Harvester> harvesters = new List<Harvester>();
    private List<Provider> providers = new List<Provider>();
    private string mode = "Full";
    private double totalEnergyStored = 0;
    private double totalMinedOre = 0;

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            HarvesterFactory factory = new HarvesterFactory();
            var harvester = factory.ProduceHarvester(arguments);
            harvesters.Add(harvester);

            return $"Successfully registered {arguments[0]} Harvester - {arguments[1]}";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            ProviderFactory factory = new ProviderFactory();
            var provider = factory.ProduceProvider(arguments);
            providers.Add(provider);

            return $"Successfully registered {arguments[0]} Provider - {arguments[1]}";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    public string Day()
    {

        providers.ForEach(h => totalEnergyStored += h.EnergyOutput);

        var oreProduced = 0.0;

        switch (mode)
        {
            case "Full":
                var energyReq = harvesters.Sum(h => h.EnergyRequirement);
                if (energyReq <= totalEnergyStored)
                {
                    var minedOre = harvesters.Sum(h => h.OreOutput);

                    totalEnergyStored -= energyReq;
                    totalMinedOre += minedOre;
                    oreProduced = minedOre;
                }
                break;
            case "Half":
                energyReq = harvesters.Sum(h => h.EnergyRequirement) * 0.6;
                if (energyReq <= totalEnergyStored)
                {
                    var minedOre = harvesters.Sum(h => h.OreOutput) * 0.5;

                    totalEnergyStored -= energyReq;
                    totalMinedOre += minedOre;
                    oreProduced = minedOre;
                }
                break;
            default:
                break;
        }

        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {providers.Sum(p => p.EnergyOutput)}");
        sb.AppendLine($"Plumbus Ore Mined: {oreProduced}");

        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        mode = arguments[0];
        return $"Successfully changed working mode to {arguments[0]} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];

        if (harvesters.All(h => h.Id != id) && providers.All(h => h.Id != id))
        {
            return $"No element found with id - {id}";
        }
        else
        {
            var harverster = harvesters.FirstOrDefault(h => h.Id == id);
            var provider = providers.FirstOrDefault(p => p.Id == id);

            if (harverster == null)
            {
                return provider.ToString().Trim();
            }
            return harverster.ToString().Trim();
        }
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {totalEnergyStored}");
        sb.AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");

        return sb.ToString().Trim();
    }
}