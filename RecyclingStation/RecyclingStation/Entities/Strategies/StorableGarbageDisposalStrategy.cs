namespace RecyclingStation.Entities.Strategies
{
    using Contracts;

    public class StorableGarbageDisposalStrategy : IGarbageDisposalStrategy
    {
        public IProcessingData ProcessGarbage(IWaste garbage)
        {
            double energyProduced = 0;
            double energyUsed = (garbage.Weight * garbage.VolumePerKg) * 0.13;

            double capitalProduced = 0;
            double capitalUsed = (garbage.Weight * garbage.VolumePerKg) * 0.65;

            return new ProcessingData(energyProduced - energyUsed, capitalProduced - capitalUsed);
        }
    }
}
