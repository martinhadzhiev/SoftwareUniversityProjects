namespace RecyclingStation.Entities.Strategies
{
    using Contracts;

    public class RecyclableGarbageDisposalStrategy : IGarbageDisposalStrategy
    {
        public IProcessingData ProcessGarbage(IWaste garbage)
        {
            double energyProduced = 0;
            double energyUsed = (garbage.Weight * garbage.VolumePerKg) * 0.5;

            double capitalEarned = 400 * garbage.Weight;

            return new ProcessingData(energyProduced - energyUsed, capitalEarned);
        }
    }
}
