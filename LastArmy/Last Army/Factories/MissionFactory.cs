using System;
using System.Linq;
using System.Reflection;

public class MissionFactory : IMissionFactory
{
    public IMission CreateMission(string difficultyLevel, double neededPoints)
    {
        Type missionType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(difficultyLevel));

        ConstructorInfo missionConstructor = missionType.GetConstructors().FirstOrDefault();

        IMission mission =
            (IMission)missionConstructor.Invoke(new object[] { neededPoints });

        return mission;
    }
}