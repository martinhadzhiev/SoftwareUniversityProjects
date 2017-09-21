using System;
using System.Linq;
using System.Reflection;

public class SoldierFactory : ISoldierFactory
{
    public ISoldier CreateSoldier(string soldierTypeName, string name,
        int age, double experience, double endurance)
    {
        Type soldierType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(soldierTypeName));

        ConstructorInfo soldierConstructor = soldierType.GetConstructors().FirstOrDefault();

        ISoldier soldier =
            (ISoldier)soldierConstructor.Invoke(new object[] { name, age, experience, endurance });

        return soldier;
    }
}