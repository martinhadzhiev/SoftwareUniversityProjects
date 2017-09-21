using System.Text;

public class CommonItem : AbstractItem
{
    public CommonItem(string name, long strengthBonus, long agilityBonus,
        long intelligenceBonus, long hitPointsBonus, long damageBonus)
        : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus)
    {

    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        result.AppendLine($"###Item: {this.Name}");
        result.AppendLine($"###+{this.StrengthBonus} Strength");
        result.AppendLine($"###+{this.AgilityBonus} Agility");
        result.AppendLine($"###+{this.IntelligenceBonus} Intelligence");
        result.AppendLine($"###+{this.HitPointsBonus} HitPoints");
        result.Append($"###+{this.DamageBonus} Damage");

        return result.ToString();
    }
}