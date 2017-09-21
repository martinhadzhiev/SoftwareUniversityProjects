namespace RecyclingStation.Contracts
{
    public interface IWasteFactory
    {
        IWaste Create(object[] arguments);
    }
}