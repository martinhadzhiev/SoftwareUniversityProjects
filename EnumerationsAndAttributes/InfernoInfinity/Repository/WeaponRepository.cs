namespace InfernoInfinity.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using Enitites;

    public class WeaponRepository
    {
        private readonly IList<Weapon> weapons;

        public WeaponRepository()
        {
            this.weapons = new List<Weapon>();
        }

        public void AddWeapon(Weapon weapon)
        {
            this.weapons.Add(weapon);
        }

        public Weapon GetWeapon(string name)
        {
            return this.weapons.FirstOrDefault(w => w.Name == name);
        }
    }
}
