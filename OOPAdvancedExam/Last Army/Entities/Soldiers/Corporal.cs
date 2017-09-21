using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Corporal : Soldier
{
    private const double OverallSkillMiltiplier = 2.5;

    public Corporal(string name, int age, double experience,
        double endurance)
        : base(name, age, experience, endurance, OverallSkillMiltiplier)
    {
        this.WeaponsAllowed = new Collection<string>()
        {
            "Gun",
            "AutomaticMachine",
            "MachineGun",
            "Helmet",
            "Knife"
        };
    }

    protected override IReadOnlyList<string> WeaponsAllowed { get; }
}
