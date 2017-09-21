using System.Collections;
using System.Collections.Generic;

public class LinkedList<T> : IEnumerable<T>
{
    private readonly IList<T> data;

    public LinkedList()
    {
        this.data = new List<T>();
    }

    public int Count
    {
        get { return this.data.Count; }
    }

    public void Add(T element)
    {
        this.data.Add(element);
    }

    public bool Remove(T element)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (this.data[i].Equals(element))
            {
                this.data.RemoveAt(i);
                return true;
            }
        }
        return false;
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