namespace Logger.Entities.Layouts.Factory
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Interfaces;

    public class LayoutFactory
    {
        public ILayout GetInstance(string layoutName)
        {
            Type layouType = Assembly.GetExecutingAssembly()
                .GetTypes().FirstOrDefault(t => t.Name == layoutName);

            return (ILayout)Activator.CreateInstance(layouType);
        }
    }
}