namespace BashSoft.IO
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Contracts;
    using Execptions;

    public class CommandInterpreter : IInterpreter
    {
        private readonly IContentComparer judge;
        private readonly IDatabase repository;
        private readonly IDirectoryManager inputOutputManager;

        public CommandInterpreter(IContentComparer judge, IDatabase repository,
            IDirectoryManager inputOutputManager)
        {
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }

        public void InterpretCommand(string input)
        {
            string[] data = input.Split();
            string commandName = data[0];

            try
            {
                IExecutable command = this.ParseCommand(input, commandName, data);
                command.Execute();
            }
            catch (Exception e)
            {
                OutputWriter.DisplayException(e.Message);
            }
        }

        private IExecutable ParseCommand(string input, string command, string[] data)
        {
            object[] parametersForCommandConstructor = new object[]
            {
                input,data
            };

            Type commandType = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(type => type.GetCustomAttributes(typeof(AliasAttribute))
                .Where(attr => attr.Equals(command)).ToArray().Length > 0);

            if (commandType == null)
            {
                throw new InvalidCommandException(input);
            }

            Type interpreterType = typeof(CommandInterpreter);

            IExecutable exe = (IExecutable)Activator.CreateInstance(commandType, parametersForCommandConstructor);

            FieldInfo[] fildsOfCommand = commandType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo[] fieldsOfInterpreter = interpreterType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo field in fildsOfCommand)
            {
                Attribute attr = field.GetCustomAttribute(typeof(InjectAttribute));
                if (attr != null)
                {
                    if (fieldsOfInterpreter.Any(x => x.FieldType == field.FieldType))
                    {
                        field.SetValue(exe, fieldsOfInterpreter.First(x => x.FieldType == field.FieldType).GetValue(this));
                    }
                }
            }

            return exe;
        }
    }
}
