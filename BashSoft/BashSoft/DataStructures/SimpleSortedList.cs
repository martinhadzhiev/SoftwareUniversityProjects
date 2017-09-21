namespace BashSoft.DataStructures
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using Contracts;

    public class SimpleSortedList<T> : ISimpleOrderedBag<T> where T : IComparable<T>
    {
        private const int DefaultSize = 16;

        private T[] innerCollection;
        private int size;
        private readonly IComparer<T> comparison;

        public SimpleSortedList(IComparer<T> comparison, int capacity)
        {
            this.comparison = comparison;
            this.InitializeInnerCollection(capacity);
        }

        public SimpleSortedList(int capacity)
            : this(Comparer<T>.Create((x, y) => x.CompareTo(y)), capacity)
        {
        }

        public SimpleSortedList(IComparer<T> comparison)
            : this(comparison, DefaultSize)
        {
        }

        public SimpleSortedList()
            : this(Comparer<T>.Create((x, y) => x.CompareTo(y)), DefaultSize)
        {
        }

        public int Size { get { return this.size; } }

        public int Capacity { get { return this.innerCollection.Length; } }

        public IEnumerator<T> GetEnumerator()
        {
            for (int currentIndex = 0; currentIndex < this.Size; currentIndex++)
            {
                yield return this.innerCollection[currentIndex];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Remove(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException();
            }

            bool isRemoved = false;
            int indexOfRemovedElement = 0;

            for (int i = 0; i < this.Size; i++)
            {
                if (this.innerCollection[i].Equals(element))
                {
                    indexOfRemovedElement = i;
                    this.innerCollection[i] = default(T);
                    isRemoved = true;
                    this.size--;
                    break;
                }
            }

            if (isRemoved)
            {
                for (int i = indexOfRemovedElement; i < this.Size; i++)
                {
                    this.innerCollection[i] = this.innerCollection[i + 1];
                }

                this.innerCollection[this.Size] = default(T);
            }

            return isRemoved;
        }

        public void Add(T element)
        {
            if (this.innerCollection.Length == this.Size)
            {
                this.Resize();
            }

            this.innerCollection[size++] = element == null ? throw new ArgumentNullException() : element;
            Array.Sort(this.innerCollection, 0, this.size, this.comparison);
        }

        public void AddAll(ICollection<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }

            if (this.Size + collection.Count >= this.innerCollection.Length)
            {
                this.MultiResize(collection);
            }

            foreach (T element in collection)
            {
                this.innerCollection[this.size++] = element;
            }

            Array.Sort(this.innerCollection, 0, this.Size, comparison);
        }

        public string JoinWith(string joiner)
        {
            if (joiner == null)
            {
                throw new ArgumentNullException();
            }

            StringBuilder joinedResult = new StringBuilder();

            foreach (T element in this)
            {
                joinedResult.Append(element);
                joinedResult.Append(joiner);
            }
            joinedResult.Remove(joinedResult.Length - joiner.Length, joiner.Length);

            return joinedResult.ToString();
        }

        private void InitializeInnerCollection(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException("Capacity cannot be negative!");
            }

            this.innerCollection = new T[capacity];
        }

        private void Resize()
        {
            T[] resizedCollection = new T[this.size * 2];
            Array.Copy(this.innerCollection, resizedCollection, this.size);
            this.innerCollection = resizedCollection;
        }

        private void MultiResize(ICollection<T> collection)
        {
            int newSize = this.innerCollection.Length * 2;
            while (this.Size + collection.Count >= newSize)
            {
                newSize *= 2;
            }

            T[] resizedCollection = new T[newSize];
            Array.Copy(this.innerCollection, resizedCollection, this.Size);
            this.innerCollection = resizedCollection;
        }
    }
}