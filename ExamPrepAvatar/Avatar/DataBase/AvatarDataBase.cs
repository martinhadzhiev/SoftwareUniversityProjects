using System.Collections.Generic;

public static class AvatarDataBase
{
    public static Dictionary<string, Nation> nations = new Dictionary<string, Nation>()
    {
        {"AirNation",new Nation()},
        {"FireNation",new Nation()},
        {"WaterNation",new Nation()},
        {"EarthNation",new Nation()}
    };

    public static List<string> wars = new List<string>();
}