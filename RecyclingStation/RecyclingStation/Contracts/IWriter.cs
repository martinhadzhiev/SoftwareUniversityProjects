namespace RecyclingStation.Contracts
{
    public interface IWriter
    {
        void Write();

        void Store(string text);
    }
}
