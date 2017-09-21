namespace RecyclingStation.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class Engine : IEngine
    {
        private const string EngineTerminatingCommand = "TimeToRecycle";
        private const string CommandSuffix = "Command";
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string command = string.Empty;

            while ((command = reader.Read()) != EngineTerminatingCommand)
            {
                string[] commandInfo = this.Splitter(command, ' ');
                string commandName = commandInfo[0];
                object[] parameters = default(object[]);

                if (commandInfo.Length == 2)
                {
                    Type[] paramTypes =
                        new[] { typeof(string), typeof(double), typeof(double), typeof(string) };
                    string[] commandArgs = this.Splitter(commandInfo[1], '|');

                    parameters = this.ParamConvertor(commandArgs, paramTypes);
                }

                Type commandType = Assembly.GetExecutingAssembly()
                    .GetTypes().FirstOrDefault(c => c.Name == commandName + CommandSuffix);

                IExecutable commandInstance = (IExecutable)Activator.CreateInstance(commandType);
                commandInstance.Execute(parameters);
            }
        }

        private string[] Splitter(string textToSplit, char splitter)
        {
            return textToSplit.Split(new[] { splitter }, StringSplitOptions.RemoveEmptyEntries);
        }

        private object[] ParamConvertor(string[] parameters, Type[] paramTypes)
        {
            object[] result = new object[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                result[i] = Convert.ChangeType(parameters[i], paramTypes[i]);
            }

            return result;
        }
    }
}
