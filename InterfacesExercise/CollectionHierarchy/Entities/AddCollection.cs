using System.Collections.Generic;

public class AddCollection<T> : IAddCollection<T>
{
    public AddCollection()
    {
        this.collection = new List<T>();
    }

    public IList<T> collection { get; private set; }

    public int Add(T item)
    {
        this.collection.Add(item);

        int index = this.collection.Count - 1;

        return index;
    }
}