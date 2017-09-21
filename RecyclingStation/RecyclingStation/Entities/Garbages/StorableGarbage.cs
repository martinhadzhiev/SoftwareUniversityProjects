namespace RecyclingStation.Entities.Garbages
{
    public class StorableGarbage : AbstractGarbage
    {
        public StorableGarbage(string name, double volumePerKg, double weight)
            : base(name, volumePerKg, weight)
        {
        }
    }
}
