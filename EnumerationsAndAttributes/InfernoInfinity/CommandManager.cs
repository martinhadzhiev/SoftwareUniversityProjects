namespace InfernoInfinity
{
    using System;
    using Repository;
    using System.Collections.Generic;
    using Enitites;

    public class CommandManager
    {
        private WeaponRepository repository;

        public CommandManager(WeaponRepository repository)
        {
            this.repository = repository;
        }

        public void CreateWeaponCommand(IList<string> commandArgs)
        {
            var weaponInfo = commandArgs[0].Split();
            Weapon weapon = new Weapon(weaponInfo[0], weaponInfo[1], commandArgs[1]);

            this.repository.AddWeapon(weapon);
        }

        public void AddGemToWeaponCommand(IList<string> commandArgs)
        {
            string weaponName = commandArgs[0];
            int index = int.Parse(commandArgs[1]);
            string[] gemInfo = commandArgs[2].Split();
            Gem gem = new Gem(gemInfo[0], gemInfo[1]);

            this.repository.GetWeapon(weaponName).AddGem(index, gem);
        }

        public void RemoveGemFromWeapon(IList<string> commandArgs)
        {
            string weaponName = commandArgs[0];
            int index = int.Parse(commandArgs[1]);

            this.repository.GetWeapon(weaponName).RemoveGem(index);
        }

        public void PrintWeaponInfo(IList<string> commandArgs)
        {
            string weaponName = commandArgs[0];
            Weapon weaponToPrint = this.repository.GetWeapon(weaponName);

            Console.WriteLine(weaponToPrint);
        }
    }
}
