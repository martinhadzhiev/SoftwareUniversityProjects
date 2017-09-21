using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Stack<T> : IEnumerable<T>
{
    private readonly IList<T> data;

    public Stack()
    {
        this.data = new List<T>();
    }

    public void Push(params T[] items)
    {
        foreach (var item in items)
        {
            this.data.Insert(0,item);
        }
    }

    public void Pop()
    {
        if (this.data.Count <= 0)
        {
            throw new InvalidOperationException("No elements");
        }

        this.data.RemoveAt(0);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return Print().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private IEnumerable<T> Print()
    {
        foreach (var item in this.data)
        {
            yield return item;
        }
    }
}