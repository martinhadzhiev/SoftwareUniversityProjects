﻿using System.Collections.Generic;
using System.Linq;

public class HeroInventory : IInventory
{
    [Item]
    private readonly IDictionary<string, IItem> commonItems;

    private readonly IDictionary<string, IRecipe> recipeItems;

    public HeroInventory()
    {
        this.commonItems = new Dictionary<string, IItem>();
        this.recipeItems = new Dictionary<string, IRecipe>();
    }

    public long TotalStrengthBonus
    {
        get { return this.commonItems.Values.Sum(i => i.StrengthBonus); }
    }

    public long TotalAgilityBonus
    {
        get { return this.commonItems.Values.Sum(i => i.AgilityBonus); }
    }

    public long TotalIntelligenceBonus
    {
        get { return this.commonItems.Values.Sum(i => i.IntelligenceBonus); }
    }

    public long TotalHitPointsBonus
    {
        get { return this.commonItems.Values.Sum(i => i.HitPointsBonus); }
    }

    public long TotalDamageBonus
    {
        get { return this.commonItems.Values.Sum(i => i.DamageBonus); }
    }

    public void AddCommonItem(IItem item)
    {
        this.commonItems.Add(item.Name, item);
        this.CheckRecipes();
    }

    public void AddRecipeItem(IRecipe recipe)
    {
        this.recipeItems.Add(recipe.Name, recipe);
        this.CheckRecipes();
    }

    private void CheckRecipes()
    {
        foreach (IRecipe recipe in this.recipeItems.Values)
        {
            List<string> requiredItems = recipe.RequiredItems.ToList();

            foreach (IItem commonItem in this.commonItems.Values)
            {
                if (requiredItems.Contains(commonItem.Name))
                {
                    requiredItems.Remove(commonItem.Name);
                }
            }

            if (requiredItems.Count == 0)
            {
                this.CombineRecipe(recipe);
            }
        }
    }

    private void CombineRecipe(IRecipe recipe)
    {
        IList<string> requiredItems = recipe.RequiredItems;

        for (int i = 0; i < requiredItems.Count; i++)
        {
            string item = requiredItems[i];
            this.commonItems.Remove(item);
        }

        IItem newItem = new CommonItem(recipe.Name,
            recipe.StrengthBonus,
            recipe.AgilityBonus,
            recipe.IntelligenceBonus,
            recipe.HitPointsBonus,
            recipe.DamageBonus);

        this.commonItems.Add(newItem.Name, newItem);
    }
}