using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Ranker : Soldier
{
    private const double OverallSkillMiltiplier = 1.5;

    public Ranker(string name, int age, double experience,
        double endurance)
        : base(name, age, experience, endurance, OverallSkillMiltiplier)
    {
        this.WeaponsAllowed = new Collection<string>()
        {
            "Gun",
            "AutomaticMachine",
            "Helmet"
        };
    }

    protected override IReadOnlyList<string> WeaponsAllowed { get; }
}
