namespace InfernoInfinity.Enitites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Enums;
    using Type = Enums.Type;

    public class Weapon
    {
        private readonly Rarity rarity;
        private readonly Type weaponType;
        private readonly List<Gem> gems;
        private readonly int[] damage;
        private int sockets;

        public Weapon(string rarity, string type, string name)
        {
            this.Name = name;
            Enum.TryParse(type, out weaponType);
            Enum.TryParse(rarity, out this.rarity);
            this.sockets = (int)this.weaponType;
            this.damage = SetDamage(type);
            this.gems = new List<Gem>(this.sockets);
        }

        public string Name { get; private set; }

        private int[] SetDamage(string type)
        {
            int[] damage = default(int[]);

            switch (type)
            {
                case "Axe":
                    damage = new int[] { 5 * (int)this.rarity, 10 * (int)this.rarity };
                    break;
                case "Sword":
                    damage = new int[] { 4 * (int)this.rarity, 6 * (int)this.rarity };
                    break;
                case "Knife":
                    damage = new int[] { 3 * (int)this.rarity, 4 * (int)this.rarity };
                    break;
            }

            return damage;
        }

        public void AddGem(int index, Gem gem)
        {
            if (index < this.gems.Capacity)
            {
                try
                {
                    this.RemoveGem(index);
                }
                catch
                {
                }

                this.gems.Insert(index, gem);
                this.damage[0] += gem.Strength * 2 + gem.Agility;
                this.damage[1] += gem.Strength * 3 + gem.Agility * 4;
            }
        }

        public void RemoveGem(int index)
        {
            if (index < this.gems.Count)
            {
                Gem gem = this.gems[index];
                this.damage[0] -= gem.Strength * 2 + gem.Agility;
                this.damage[1] -= gem.Strength * 3 + gem.Agility * 4;

                this.gems.RemoveAt(index);
            }
        }

        public override string ToString()
        {
            int totalStrenght = this.gems.Sum(g => g.Strength);
            int totalAgility = this.gems.Sum(g => g.Agility);
            int totalVitality = this.gems.Sum(g => g.Vitality);

            return
                $"{this.Name}: {this.damage[0]}-{this.damage[1]} Damage, +{totalStrenght} Strength, +{totalAgility} Agility, +{totalVitality} Vitality";
        }
    }
}
