namespace PetClinics
{
    using System;
    using System.Collections.Generic;
    using Enitites;

    public class Repository
    {
        private IDictionary<string, Pet> pets;
        private IDictionary<string, Clinic> clinics;

        public Repository()
        {
            this.pets = new Dictionary<string, Pet>();
            this.clinics = new Dictionary<string, Clinic>();
        }

        public void CreateEnitity(IList<string> commandArgs)
        {
            string entityType = commandArgs[0];

            if (entityType == "Pet")
            {
                string petName = commandArgs[1];
                int petAge = int.Parse(commandArgs[2]);
                string petKind = commandArgs[3];

                this.pets.Add(petName, new Pet(petName, petAge, petKind));
            }
            else if (entityType == "Clinic")
            {
                string name = commandArgs[1];
                int roomCount = int.Parse(commandArgs[2]);
                try
                {
                    this.clinics.Add(name, new Clinic(name, roomCount));
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public bool AddPetToClinic(IList<string> commandArgs)
        {
            string petName = commandArgs[0];
            string clinicName = commandArgs[1];

            Pet pet = this.pets[petName];
            Clinic clinic = this.clinics[clinicName];

            bool isSuccessful = clinic.TryAddPet(pet);

            Console.WriteLine(isSuccessful);

            return isSuccessful;
        }

        public void ReleasePet(IList<string> commandArgs)
        {
            string clinicName = commandArgs[0];

            Clinic currentClinic = this.clinics[clinicName];

            Console.WriteLine(currentClinic.TryReleasePet());
        }

        public void CheckEmptyRooms(IList<string> commandArgs)
        {
            string clinicName = commandArgs[0];

            Clinic currentClinic = this.clinics[clinicName];

            Console.WriteLine(currentClinic.HasEmptyRooms());
        }

        public void PrintClinicInfo(IList<string> commandArgs)
        {
            string clinicName = commandArgs[0];

            Clinic currentClinic = this.clinics[clinicName];
            string result = null;

            if (commandArgs.Count == 1)
            {
                result = currentClinic.Print();
            }
            else
            {
                int roomIndex = int.Parse(commandArgs[1]) - 1;
                result = currentClinic.Print(roomIndex);
            }

            Console.WriteLine(result);
        }
    }
}
