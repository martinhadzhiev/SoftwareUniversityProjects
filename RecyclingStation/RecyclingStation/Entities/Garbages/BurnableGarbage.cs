namespace RecyclingStation.Entities.Garbages
{
    public class BurnableGarbage : AbstractGarbage
    {
        public BurnableGarbage(string name, double volumePerKg, double weight)
            : base(name, volumePerKg, weight)
        {
        }
    }
}
