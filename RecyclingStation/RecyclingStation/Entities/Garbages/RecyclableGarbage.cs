namespace RecyclingStation.Entities.Garbages
{
    public class RecyclableGarbage : AbstractGarbage
    {
        public RecyclableGarbage(string name, double volumePerKg, double weight)
            : base(name, volumePerKg, weight)
        {
        }
    }
}
