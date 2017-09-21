namespace RecyclingStation.Entities.Garbages
{
    using Contracts;

    public abstract class AbstractGarbage : IWaste
    {
        protected AbstractGarbage(string name, double volumePerKg, double weight)
        {
            this.Name = name;
            this.VolumePerKg = volumePerKg;
            this.Weight = weight;
        }

        public string Name { get; private set; }
        public double VolumePerKg { get; private set; }
        public double Weight { get; private set; }
    }
}
