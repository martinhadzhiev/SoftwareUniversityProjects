using System.Collections.Generic;
using System.Linq;

public class MyList<T> : IMyList<T>
{
    public MyList()
    {
        this.collection = new List<T>();
    }

    public IList<T> collection { get; private set; }

    public int Add(T item)
    {
        this.collection.Insert(0, item);

        return 0;
    }

    public T Remove()
    {
        T firstItem = this.collection[0];
        this.collection.Remove(firstItem);

        return firstItem;
    }
}