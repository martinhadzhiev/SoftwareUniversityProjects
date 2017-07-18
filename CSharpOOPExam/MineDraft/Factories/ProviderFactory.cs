using System.Collections.Generic;

public class ProviderFactory
{
    public Provider ProduceProvider(List<string> args)
    {
        var type = args[0];

        switch (type)
        {
            case "Solar":
                return new SolarProvider(args[1],double.Parse(args[2]));
            case "Pressure":
                return new PressureProvider(args[1], double.Parse(args[2]));
        }
        return null;
    }
}