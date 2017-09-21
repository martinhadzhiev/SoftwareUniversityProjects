namespace BarracksFactory.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Type unit = Assembly.
                GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == unitType);

            IUnit obj = (IUnit)Activator.CreateInstance(unit);

            return obj;
        }
    }
}
