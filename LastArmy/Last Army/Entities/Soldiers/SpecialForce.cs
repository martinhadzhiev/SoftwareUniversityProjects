using System.Collections.Generic;

public class SpecialForce : Soldier
{
    private const double OverallSkillMiltiplier = 3.5;

    private readonly List<string> weaponsAllowed = new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "MachineGun",
            "RPG",
            "Helmet",
            "Knife",
            "NightVision"
        };

    public SpecialForce(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance, OverallSkillMiltiplier)
    {

    }

    public override void Regenerate()
    {
        this.Endurance += 30 + this.Age;

        if (this.Endurance > 100)
        {
            this.Endurance = 100;
        }
    }
}