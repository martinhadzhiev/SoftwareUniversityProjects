using System.Collections.Generic;
using System.Linq;

public class AddRemoveCollection<T> : IAddRemoveCollection<T>
{
    public AddRemoveCollection()
    {
        this.collection = new List<T>();
    }

    public IList<T> collection { get; private set; }

    public int Add(T item)
    {
        this.collection.Insert(0,item);

        return 0;
    }

    public T Remove()
    {
        T lastItem = this.collection.Last();
        this.collection.Remove(lastItem);

        return lastItem;
    }
}