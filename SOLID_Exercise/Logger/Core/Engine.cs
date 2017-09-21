namespace Logger.Core
{
    using Interfaces;

    public class Engine
    {
        private bool isRunning;
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly Controller controller;

        public Engine(IReader reader, IWriter writer, Controller controller)
        {
            this.reader = reader;
            this.writer = writer;
            this.controller = controller;
        }

        public void Run()
        {
            this.isRunning = true;
            this.controller.InitilizeLogger(this.reader);

            while (this.isRunning)
            {
                var message = this.reader.Read();
                if (message == "END")
                {
                    this.isRunning = false;
                    continue;
                }

                this.controller.SendMessageToLogger(message);
            }

            string loggerInfo = this.controller.GetLoggerInfo();
            this.writer.Write(loggerInfo);
        }
    }
}