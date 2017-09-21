namespace Logger.Entities
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LogFile
    {
        private const string FileName = "log.txt";
        private readonly StringBuilder messages;

        public LogFile()
        {
            this.messages = new StringBuilder();
        }

        public int Size { get; private set; }

        public void Write(string message)
        {
            this.messages.AppendLine(message);
            File.AppendAllText(FileName, message + Environment.NewLine);
            this.Size += message.Where(char.IsLetter).Sum(a => a);
        }
    }
}