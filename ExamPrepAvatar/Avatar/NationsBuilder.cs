using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    public void AssignBender(List<string> benderArgs)
    {
        var benderType = benderArgs[0];
        var benderName = benderArgs[1];
        int benderPower = int.Parse(benderArgs[2]);
        double benderSecondaryElement = double.Parse(benderArgs[3]);

        BenderFactory factory = new BenderFactory();
        var bender = factory.ProduceBender(benderType, benderName, benderPower, benderSecondaryElement);
        AddBenderInNation(bender, benderType);
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[0];
        var name = monumentArgs[1];
        var affinity = int.Parse(monumentArgs[2]);

        MonumentFactory factory = new MonumentFactory();
        var monument = factory.ProduceMonument(type, name, affinity);
        AddMonument(monument, type);
    }

    public string GetStatus(string nationsType)
    {
        switch (nationsType)
        {
            case "Fire":
                return AvatarDataBase.nations["FireNation"].ToString();
            case "Air":
                return AvatarDataBase.nations["AirNation"].ToString();
            case "Water":
                return AvatarDataBase.nations["WaterNation"].ToString();
            case "Earth":
                return AvatarDataBase.nations["EarthNation"].ToString();
        }
        return "";
    }

    public void IssueWar(string nationsType)
    {
        AvatarDataBase.wars.Add(nationsType);
        var warWinner = AvatarDataBase.nations.OrderByDescending(n => n.Value.GetPower()).FirstOrDefault().Key;

        foreach (var nation in AvatarDataBase.nations)
        {
            if (!nation.Key.Equals(warWinner))
            {
                nation.Value.Benders.Clear();
                nation.Value.Monuments.Clear();
            }
        }
    }

    public string GetWarsRecord()
    {
        var sb = new StringBuilder();
        int count = 1;
        foreach (var war in AvatarDataBase.wars)
        {
            sb.AppendLine($"War {count} issued by {war}");
            count++;
        }

        return sb.ToString().Trim();
    }

    private void AddBenderInNation(Bender bender, string nation)
    {
        switch (nation)
        {
            case "Fire":
                AvatarDataBase.nations["FireNation"].Benders.Add(bender);
                break;
            case "Air":
                AvatarDataBase.nations["AirNation"].Benders.Add(bender);
                break;
            case "Earth":
                AvatarDataBase.nations["EarthNation"].Benders.Add(bender);
                break;
            case "Water":
                AvatarDataBase.nations["WaterNation"].Benders.Add(bender);
                break;
        }
    }

    private void AddMonument(Monument monument, string nation)
    {
        switch (nation)
        {
            case "Fire":
                AvatarDataBase.nations["FireNation"].Monuments.Add(monument);
                break;
            case "Water":
                AvatarDataBase.nations["WaterNation"].Monuments.Add(monument);
                break;
            case "Earth":
                AvatarDataBase.nations["EarthNation"].Monuments.Add(monument);
                break;
            case "Air":
                AvatarDataBase.nations["AirNation"].Monuments.Add(monument);
                break;
        }
    }
}