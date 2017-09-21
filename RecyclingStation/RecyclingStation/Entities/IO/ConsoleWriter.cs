namespace RecyclingStation.Entities.IO
{
    using System;
    using System.Text;
    using Contracts;

    public class ConsoleWriter : IWriter
    {
        private readonly StringBuilder output;

        public ConsoleWriter()
        {
            this.output = new StringBuilder();
        }

        public void Write()
        {
            Console.WriteLine(this.output);
        }

        public void Store(string text)
        {
            output.AppendLine(text);
        }
    }
}
