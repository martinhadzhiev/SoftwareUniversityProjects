namespace Logger.Entities.Layouts
{
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public string Format(string dateStamp, string reportLevel, string message)
        {
            return $"{dateStamp} - {reportLevel} - {message}";
        }
    }
}
