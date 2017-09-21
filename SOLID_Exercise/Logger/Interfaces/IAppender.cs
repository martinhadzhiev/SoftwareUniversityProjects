namespace Logger.Interfaces
{
    using Enums;

    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }

        void Append(string dateStamp, string reportLevel, string message);
    }
}
