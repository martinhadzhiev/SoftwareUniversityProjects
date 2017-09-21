namespace Logger.Interfaces
{
    public interface ILogger
    {
        IAppender[] Appenders { get; }

        void Error(string dateStamp, string message);

        void Info(string dateStamp, string message);

        void Fatal(string dateStamp, string message);

        void Critical(string dateStamp, string message);

        void Warning(string dateStamp, string message);
    }
}
