namespace PetClinics.Enitites
{
    using System.Collections;
    using System.Collections.Generic;

    public class RoomRegister : IEnumerable<int>
    {
        private readonly List<Pet> rooms;
        private readonly int centerRoom;

        public RoomRegister(int roomCount)
        {
            this.centerRoom = roomCount / 2;
            this.rooms = new List<Pet>(new Pet[roomCount]);
        }

        public Pet this[int index]
        {
            get => this.rooms[index];
            set => this.rooms[index] = value;
        }

        public IEnumerator<int> GetEnumerator()
        {
            int step = 1;

            yield return this.centerRoom;

            while (step <= this.centerRoom)
            {
                yield return this.centerRoom - step;

                yield return this.centerRoom + step++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
