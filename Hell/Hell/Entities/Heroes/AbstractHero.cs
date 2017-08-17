using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class AbstractHero : IHero
{
    private readonly IInventory inventory;
    private long strength;
    private long agility;
    private long intelligence;
    private long hitPoints;
    private long damage;

    protected AbstractHero(string name, long strength, long agility, long intelligence, long hitPoints, long damage)
    {
        this.Name = name;
        this.strength = strength;
        this.agility = agility;
        this.intelligence = intelligence;
        this.hitPoints = hitPoints;
        this.damage = damage;
        this.inventory = new HeroInventory();
    }

    public string Name { get; private set; }

    public IInventory Inventory
    {
        get { return this.inventory; }
    }

    public long Strength
    {
        get { return this.strength + this.inventory.TotalStrengthBonus; }
        set { this.strength = value; }
    }

    public long Agility
    {
        get { return this.agility + this.inventory.TotalAgilityBonus; }
        set { this.agility = value; }
    }

    public long Intelligence
    {
        get { return this.intelligence + this.inventory.TotalIntelligenceBonus; }
        set { this.intelligence = value; }
    }

    public long HitPoints
    {
        get { return this.hitPoints + this.inventory.TotalHitPointsBonus; }
        set { this.hitPoints = value; }
    }

    public long Damage
    {
        get { return this.damage + this.inventory.TotalDamageBonus; }
        set { this.damage = value; }
    }

    public long PrimaryStats
    {
        get { return this.Strength + this.Agility + this.Intelligence; }
    }

    public long SecondaryStats
    {
        get { return this.HitPoints + this.Damage; }
    }

    public ICollection<IItem> Items
    {
        get
        {
            Type inventoryType = this.Inventory.GetType();
            FieldInfo commonItemsField = inventoryType
                .GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(f => Attribute.IsDefined(f, typeof(ItemAttribute)));

            Dictionary<string, IItem> commonItems =
                (Dictionary<string, IItem>)commonItemsField.GetValue(this.Inventory);

            return commonItems.Values;
        }
    }

    public void AddRecipe(IRecipe recipe)
    {
        this.inventory.AddRecipeItem(recipe);
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        result.AppendLine($"Hero: {this.Name}, Class: {this.GetType().Name}");
        result.AppendLine($"HitPoints: {this.HitPoints}, Damage: {this.Damage}");
        result.AppendLine($"Strength: {this.Strength}");
        result.AppendLine($"Agility: {this.Agility}");
        result.AppendLine($"Intelligence: {this.Intelligence}");

        ICollection<IItem> commonItems = this.Items;

        if (commonItems.Count == 0)
        {
            result.Append("Items: None");
        }
        else
        {
            result.AppendLine("Items:");
            foreach (IItem item in commonItems)
            {
                result.AppendLine(item.ToString());
            }
        }

        return result.ToString().Trim();
    }
}