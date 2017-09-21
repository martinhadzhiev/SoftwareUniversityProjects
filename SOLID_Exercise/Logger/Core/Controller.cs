namespace Logger.Core
{
    using System;
    using System.Globalization;
    using System.Reflection;
    using Entities;
    using Entities.Appenders.Factory;
    using Entities.Layouts.Factory;
    using Enums;
    using Interfaces;

    public class Controller
    {
        private readonly LayoutFactory layoutFactory;
        private readonly AppenderFactory appenderFactory;
        private ILogger logger;

        public Controller(LayoutFactory layoutFactory, AppenderFactory appenderFactory)
        {
            this.layoutFactory = layoutFactory;
            this.appenderFactory = appenderFactory;
        }

        private IAppender[] ReadAllAppenders(IReader reader)
        {
            int appenderCount = int.Parse(reader.Read());
            IAppender[] appenders = new IAppender[appenderCount];

            for (int i = 0; i < appenderCount; i++)
            {
                string[] appenderTokens = reader.Read().Split();
                string appenderType = appenderTokens[0];
                string layoutType = appenderTokens[1];

                ILayout layout = this.layoutFactory.GetInstance(layoutType);
                IAppender appender = this.appenderFactory.GetInstance(appenderType, layout);

                if (appenderTokens.Length > 2)
                {
                    string reportLevelName = ConvertToTitleCase(appenderTokens[2]);
                    ReportLevel reportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportLevelName);
                    appender.ReportLevel = reportLevel;
                }

                appenders[i] = appender;
            }

            return appenders;
        }

        private string ConvertToTitleCase(string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }

        public void InitilizeLogger(IReader reader)
        {
            IAppender[] appenders = this.ReadAllAppenders(reader);
            this.logger = new Logger(appenders);
        }

        public void SendMessageToLogger(string message)
        {
            string[] tokens = message.Split('|');
            string methodName = this.ConvertToTitleCase(tokens[0]);
            MethodInfo currentMethod = typeof(Logger).GetMethod(methodName);
            currentMethod.Invoke(this.logger, new object[] { tokens[1], tokens[2] });
        }

        public string GetLoggerInfo()
        {
            return this.logger.ToString();
        }
    }
}