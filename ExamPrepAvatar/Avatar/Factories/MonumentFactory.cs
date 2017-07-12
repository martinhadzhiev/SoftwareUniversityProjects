public class MonumentFactory
{
    public Monument ProduceMonument(string type, string name, int affinity)
    {
        switch (type)
        {
            case "Fire":
                return new FireMonument(name,affinity);
            case "Air":
                return new AirMonument(name, affinity);
            case "Water":
                return new WaterMonument(name, affinity);
            case "Earth":
                return new EarthMonument(name, affinity);
        }
        return null;
    }
}