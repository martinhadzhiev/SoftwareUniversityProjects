namespace Logger.Interfaces
{
    public interface ILayout
    {
        string Format(string dateStamp , string reportLevel , string message);
    }
}
