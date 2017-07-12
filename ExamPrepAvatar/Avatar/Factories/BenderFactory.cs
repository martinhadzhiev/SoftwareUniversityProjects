public class BenderFactory
{
    public Bender ProduceBender(string type, string name, int power, double secondaryElement)
    {
        switch (type)
        {
            case "Fire":
                return new FireBender(name,power,secondaryElement);
            case "Air":
                return new AirBender(name, power, secondaryElement);
            case "Water":
                return new WaterBender(name, power, secondaryElement);
            case "Earth":
                return new EarthBender(name, power, secondaryElement);
        }
        return null;
    }
}