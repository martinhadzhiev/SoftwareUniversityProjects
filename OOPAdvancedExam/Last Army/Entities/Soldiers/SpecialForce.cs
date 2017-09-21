using System.Collections.Generic;
using System.Collections.ObjectModel;

public class SpecialForce : Soldier
{
    private const double OverallSkillMiltiplier = 3.5;

    public SpecialForce(string name, int age, double experience,
        double endurance)
        : base(name, age, experience, endurance, OverallSkillMiltiplier)
    {
        this.WeaponsAllowed = new Collection<string>()
            {
                "Gun",
                "AutomaticMachine",
                "MachineGun",
                "RPG",
                "Helmet",
                "Knife",
                "NightVision"
            };
    }

    protected override IReadOnlyList<string> WeaponsAllowed { get; }

    public override void Regenerate()
    {
        //TODO: Set regen to 30 plus age;
    }
}
