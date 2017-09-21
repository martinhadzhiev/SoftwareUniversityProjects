using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

[TestFixture]
public class MissionControllerTests
{

    private MissionController sut;
    private IArmy army = new Army();
    private IWareHouse wareHouse = new WareHouse();

    [SetUp]
    private void Init()
    {
        this.sut = new MissionController(army, wareHouse);
    }

    [Test]
    public void PerformMission()
    {
        //public string PerformMission(IMission mission)

        Type type = typeof(MissionController);
        IMission mission = new Easy(2);

        MethodInfo method = type.GetMethods().FirstOrDefault(m => m.Name == "PerformMission");

        Assert.DoesNotThrow(() => method.Invoke(this.sut, new object[] { mission }));
    }

    [Test]
    public void ExecuteMission()
    {
        // private bool ExecuteMission(IMission mission, List<ISoldier> missionTeam)
    }
    [Test]
    public void CollectMissionTeam()
    {
        //private List<ISoldier> CollectMissionTeam(IMission mission)
    }
    [Test]
    public void FailMisionsOnHold()
    {
        //public void FailMissionsOnHold()

    }
}
