using System;
using System.Linq;
using System.Reflection;

public class AmmunitionFactory : IAmmunitionFactory
{
    public IAmmunition CreateAmmunition(string ammunitionName)
    {
        Type ammunitionType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(ammunitionName));

        ConstructorInfo ammunitionConstructor = ammunitionType
            .GetConstructors().FirstOrDefault();

        IAmmunition ammunition = (IAmmunition)ammunitionConstructor
             .Invoke(new object[] { ammunitionName });

        return ammunition;
    }
}