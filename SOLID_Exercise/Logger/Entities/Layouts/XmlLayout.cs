namespace Logger.Entities.Layouts
{
    using System.Text;
    using Interfaces;

    public class XmlLayout : ILayout
    {
        public string Format(string dateStamp, string reportLevel, string message)
        {
            StringBuilder formattedMessage = new StringBuilder();

            formattedMessage.AppendLine("<log>");
            formattedMessage.AppendLine($"    <date>{dateStamp}</date>");
            formattedMessage.AppendLine($"    <level>{reportLevel}</level>");
            formattedMessage.AppendLine($"    <message>{message}</message>");
            formattedMessage.AppendLine("</log>");

            return formattedMessage.ToString().Trim();
        }
    }
}