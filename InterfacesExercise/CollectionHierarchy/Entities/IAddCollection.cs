using System.Collections.Generic;

public interface IAddCollection<T>
{
    IList<T> collection { get; }

    int Add(T item);
}