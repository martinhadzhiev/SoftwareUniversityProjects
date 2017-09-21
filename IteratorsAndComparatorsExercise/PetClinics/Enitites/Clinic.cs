namespace PetClinics.Enitites
{
    using System;
    using System.Text;

    public class Clinic
    {
        private int roomCount;
        private readonly RoomRegister roomRegister;
        private int occupiedRooms;

        public Clinic(string name, int roomCount)
        {
            this.Name = name;
            this.RoomCount = roomCount;
            this.occupiedRooms = 0;
            this.roomRegister = new RoomRegister(this.roomCount);
        }

        private string Name { get; set; }

        private int RoomCount
        {
            get { return this.roomCount; }
            set
            {
                if (value % 2 == 0)
                {
                    throw new InvalidOperationException("Invalid Operation!");
                }
                this.roomCount = value;
            }
        }

        public bool TryAddPet(Pet currentPet)
        {
            foreach (var roomIndex in this.roomRegister)
            {
                if (this.roomRegister[roomIndex] == null)
                {
                    this.roomRegister[roomIndex] = currentPet;
                    this.occupiedRooms++;
                    return true;
                }
            }

            return false;
        }

        public bool TryReleasePet()
        {
            int centralRoomIndex = this.roomCount / 2;
            for (int i = 0; i < this.roomCount; i++)
            {
                int currentIndex = (centralRoomIndex + i) % this.roomCount;
                if (this.roomRegister[currentIndex] != null)
                {
                    this.roomRegister[currentIndex] = null;
                    this.occupiedRooms--;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            return this.occupiedRooms < this.roomCount;
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.roomCount; i++)
            {
                sb.AppendLine(this.Print(i));
            }

            return sb.ToString().TrimEnd();
        }

        public string Print(int roomIndex)
        {
            return this.roomRegister[roomIndex]?.ToString() ?? "Room empty";
        }
    }
}
