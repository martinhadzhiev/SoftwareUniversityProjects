namespace Database.Entities
{
    using System;
    using System.Linq;

    public class Database
    {
        private readonly int[] integers;
        private int count;

        public Database(params int[] integers)
        {
            this.integers = new int[16];
            StoreInitialElements(integers);
            this.count = integers.Length;
        }

        private void StoreInitialElements(int[] elements)
        {
            if (elements.Length > 16)
            {
                throw new InvalidOperationException("Integers must be 16 or less.");
            }

            for (int i = 0; i < elements.Length; i++)
            {
                this.integers[i] = elements[i];
            }
        }

        public void Add(int element)
        {
            if (this.count >= this.integers.Length)
            {
                throw new InvalidOperationException("No empty indexes!");
            }

            this.integers[count++] = element;
        }

        public void Remove()
        {
            bool isArrayEmpty = this.integers.All(i => i == null);

            if (isArrayEmpty)
            {
                throw new InvalidOperationException("Array is empty");
            }

            this.integers[--this.count] = 0;
        }

        public int[] Fetch()
        {
            return this.integers;
        }
    }
}
