namespace CutomList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class MyList<T> : IEnumerable<T> where T : IComparable
    {
        private IList<T> data;

        public MyList()
        {
            this.data = new List<T>();
        }

        public IList<T> Data
        {
            get { return this.data; }
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove(int index)
        {
            var element = this.data[index];
            this.data.RemoveAt(index);

            return element;
        }

        public bool Contains(T element)
        {
            return this.data.Contains(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var firstElement = this.data[firstIndex];

            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = firstElement;
        }

        public int CountGreaterThan(T element)
        {
            var count = 0;

            foreach (var e in this.data)
            {
                if (element.CompareTo(e) == -1)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            return this.data.Max();
        }

        public T Min()
        {
            return this.data.Min();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
