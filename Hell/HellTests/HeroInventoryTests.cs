using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

[TestFixture]
public class HeroInventoryTests
{
    private HeroInventory sut;

    [SetUp]
    public void TestInit()
    {
        this.sut = new HeroInventory();
    }

    [Test]
    public void AddCommonItem()
    {
        CommonItem item0 = new CommonItem("item", 1, 2, 3, 4, 5);
        CommonItem item1 = new CommonItem("item1", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item0);
        this.sut.AddCommonItem(item1);
        Type clazz = typeof(HeroInventory);
        var field = clazz.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
            .FirstOrDefault(f => f.GetCustomAttributes(typeof(ItemAttribute)) != null);
        var collection = (Dictionary<string, IItem>)field.GetValue(this.sut);

        Assert.AreEqual(2, collection.Count);
    }

    [Test]
    public void AddRecipeItem()
    {
        RecipeItem item1 = new RecipeItem("item1", 1, 2, 3, 4, 5, new List<string>());

        this.sut.AddRecipeItem(item1);
        Type clazz = typeof(HeroInventory);
        var field = clazz.GetField("recipeItems", BindingFlags.Instance | BindingFlags.NonPublic);

        var collection = (Dictionary<string, IRecipe>)field.GetValue(this.sut);

        Assert.AreEqual(1, collection.Count);
    }

    [Test]
    public void StrengthBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 10, 20, 30, 40, 50);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(10, this.sut.TotalStrengthBonus);
    }

    [Test]
    public void AgilityBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 10, 20, 30, 40, 50);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(20, this.sut.TotalAgilityBonus);
    }

    [Test]
    public void IntelligenceBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 10, 20, 30, 40, 50);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(30, this.sut.TotalIntelligenceBonus);
    }

    [Test]
    public void HitPointsBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 10, 20, 30, 40, 50);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(40, this.sut.TotalHitPointsBonus);
    }

    [Test]
    public void DamageBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 10, 20, 30, 40, 50);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(50, this.sut.TotalDamageBonus);
    }

    [Test]
    public void CombineRecipe()
    {
        RecipeItem recipe = new RecipeItem("item", 100, 2, 3, 4, 5, new List<string>() { "item", "item1", "item2" });
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);
        CommonItem item1 = new CommonItem("item1", 1, 2, 3, 4, 5);
        CommonItem item3 = new CommonItem("item2", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);
        this.sut.AddCommonItem(item1);
        this.sut.AddCommonItem(item3);
        Type type = typeof(HeroInventory);
        MethodInfo method = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
            .FirstOrDefault(m => m.Name == "CombineRecipe");


        method.Invoke(this.sut, new[] { recipe });
        Assert.AreEqual(100, this.sut.TotalStrengthBonus);
    }

    [Test]
    public void CheckRecipe()
    {
        RecipeItem recipe = new RecipeItem("recipe", 100, 2, 3, 4, 5, new List<string>() { "item", "itemm" });
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);
        CommonItem itemm = new CommonItem("itemm", 1, 2, 3, 4, 5);
        CommonItem itemmm = new CommonItem("itemmmm", 1, 2, 3, 4, 5);
        CommonItem itemmmm = new CommonItem("itemmmmmm", 1, 2, 3, 4, 5);

        this.sut.AddRecipeItem(recipe);
        this.sut.AddCommonItem(item);
        this.sut.AddCommonItem(itemm);
        this.sut.AddCommonItem(itemmm);
        this.sut.AddCommonItem(itemmmm);
        Type heroInventoryType = typeof(HeroInventory);
        FieldInfo commonItems = heroInventoryType
            .GetField("commonItems", BindingFlags.Instance | BindingFlags.NonPublic);

        Dictionary<string, IItem> items = (Dictionary<string, IItem>)commonItems.GetValue(this.sut);

        Assert.AreEqual(3, items.Count);
    }

    [Test]
    public void ChainingRecipes()
    {
        List<string> recipeComponents1 = new List<string> { "BootsOfSpeed" };
        IRecipe recipe1 = new RecipeItem("BootsOfTravell", 100, 100, 100, 100, 100, recipeComponents1);
        IItem boots = new CommonItem("BootsOfSpeed", 10, 10, 10, 10, 10);

        List<string> recipeComponents2 = new List<string> { "BootsOfTravell" };
        IRecipe recipe2 = new RecipeItem("BootsOfTravell2", 200, 200, 200, 200, 200, recipeComponents2);

        this.sut.AddCommonItem(boots);
        this.sut.AddRecipeItem(recipe1);
        this.sut.AddRecipeItem(recipe2);
        long totalStatsBonus = this.sut.TotalAgilityBonus
                               + this.sut.TotalStrengthBonus
                               + this.sut.TotalIntelligenceBonus
                               + this.sut.TotalHitPointsBonus
                               + this.sut.TotalDamageBonus;

        Assert.AreEqual(1000, totalStatsBonus);
    }
}