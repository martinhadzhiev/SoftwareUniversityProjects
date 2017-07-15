public class RaceFactory
{
    public Race ProduceRace(string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual":
                return new CasualRace(length,route,prizePool);

            case "Drag":
                return new DragRace(length, route, prizePool);

            case "Drift":
                return new DragRace(length, route, prizePool);
        }

        return null;
    }
}