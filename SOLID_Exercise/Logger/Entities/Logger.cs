namespace Logger.Entities
{
    using System;
    using System.Text;
    using Enums;
    using Interfaces;

    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = appenders;
        }

        public IAppender[] Appenders { get; }

        private void Log(string dateStamp, string reportLevel, string message)
        {
            foreach (IAppender appender in this.Appenders)
            {
                ReportLevel rep = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportLevel);

                if (rep >= appender.ReportLevel)
                {
                    appender.Append(dateStamp, reportLevel, message);
                }
            }
        }

        public void Error(string dateStamp, string message)
        {
            this.Log(dateStamp, "Error", message);
        }

        public void Info(string dateStamp, string message)
        {
            this.Log(dateStamp, "Info", message);
        }

        public void Fatal(string dateStamp, string message)
        {
            this.Log(dateStamp, "Fatal", message);
        }

        public void Critical(string dateStamp, string message)
        {
            this.Log(dateStamp, "Critical", message);
        }

        public void Warning(string dateStamp, string message)
        {
            this.Log(dateStamp, "Warning", message);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Logger info");

            foreach (IAppender appender in this.Appenders)
            {
                result.AppendLine(appender.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
