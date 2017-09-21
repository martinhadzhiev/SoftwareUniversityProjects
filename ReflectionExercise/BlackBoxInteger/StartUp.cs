namespace BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class StartUp
    {
        static void Main()
        {
            BlackBoxInt blackBoxInt = CreateInstance();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandArgs = command.Split('_');
                string methodName = commandArgs[0];
                int parameter = int.Parse(commandArgs[1]);
                InvokeMethod(blackBoxInt, methodName, parameter);
                Console.WriteLine(PrintInnerValue(typeof(BlackBoxInt), blackBoxInt));
            }
        }

        private static void InvokeMethod(BlackBoxInt blackBoxInt, string methodName, int parameter)
        {
            MethodInfo method =
                                typeof(BlackBoxInt)
                                .GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance
                                | BindingFlags.Static | BindingFlags.Public);

            method.Invoke(blackBoxInt, new object[] { parameter });
        }

        private static BlackBoxInt CreateInstance()
        {
            Type blackBoxType = typeof(BlackBoxInt);
            ConstructorInfo ctor =
                blackBoxType
                .GetConstructors(BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance)
                .FirstOrDefault(c => !c.GetParameters().Any());

            BlackBoxInt blackBoxInstance = (BlackBoxInt)ctor.Invoke(new object[] { });

            return blackBoxInstance;
        }

        private static int PrintInnerValue(Type type, BlackBoxInt blackBox)
        {
            int result = 0;

            FieldInfo field = type.
                GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                .FirstOrDefault();

            result = (int)field.GetValue(blackBox);

            return result;
        }
    }
}
