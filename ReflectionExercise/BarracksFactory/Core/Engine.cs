namespace BarracksFactory.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Contracts;

    class Engine : IRunnable
    {
        private string[] data;
        private readonly IRepository repository;
        private readonly IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    this.data = input.Split();
                    string commandName = data[0];
                    string result = ExecuteCommand(commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private string ExecuteCommand(string commandName)
        {
            string result = string.Empty;

            string commandClassName = string.Concat(commandName[0].ToString().ToUpper(), string.Join("", commandName.Skip(1)), "Command");
            string commandLocation = string.Concat("BarracksFactory.Core.Commands.", commandClassName);

            try
            {
                Type commandType = Type.GetType(commandLocation);

                IExecutable instance = (IExecutable)Activator.CreateInstance(commandType);

                IExecutable cmd = InjectDependencies(instance);

                result = cmd.Execute();
            }
            catch
            {
                result = "Invalid Command!";
            }

            return result;
        }

        private IExecutable InjectDependencies(IExecutable command)
        {
            FieldInfo[] commandField =
                command.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            FieldInfo[] engineFields =
                this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo field in commandField)
            {
                Attribute fieldAttribute = field.GetCustomAttribute(typeof(InjectAttribute));

                if (fieldAttribute != null)
                {
                    if (engineFields.Any(f => f.FieldType == field.FieldType))
                    {
                        field.SetValue(command, engineFields.First(f => f.FieldType == field.FieldType).GetValue(this));
                    }
                }
            }

            return command;
        }
    }
}
