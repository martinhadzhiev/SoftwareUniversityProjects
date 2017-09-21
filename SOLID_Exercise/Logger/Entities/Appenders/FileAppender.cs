namespace Logger.Entities.Appenders
{
    using Enums;
    using Interfaces;

    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout) : base(layout)
        {
            this.File = new LogFile();
        }

        public LogFile File { get; private set; }

        public override void Append(string timeStamp, string reportLevel, string message)
        {
            this.Count++;
            string formattedMsg = this.Layout.Format(timeStamp, reportLevel, message);
            this.File.Write(formattedMsg);
        }

        public override string ToString()
        {
            return base.ToString() + $", File size: {this.File.Size}";
        }
    }
}