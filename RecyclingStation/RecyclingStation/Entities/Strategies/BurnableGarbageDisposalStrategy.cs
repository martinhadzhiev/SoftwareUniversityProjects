namespace RecyclingStation.Entities.Strategies
{
    using Contracts;

    public class BurnableGarbageDisposalStrategy : IGarbageDisposalStrategy
    {
        public IProcessingData ProcessGarbage(IWaste garbage)
        {
            double energyProduced = garbage.Weight * garbage.VolumePerKg;
            double energyUsed = (garbage.Weight * garbage.VolumePerKg) * 0.2;

            return new ProcessingData(energyProduced - energyUsed, 0);
        }
    }
}
