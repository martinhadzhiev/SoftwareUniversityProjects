using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> :IEnumerable
{
    private readonly List<string> data;
    private int currentIndex;

    public ListyIterator(params string[] items)
    {
        this.data = new List<string>(items);
        this.currentIndex = 0;
    }

    public bool Move()
    {
        if (this.currentIndex + 1 >= this.data.Count)
        {
            return false;
        }

        this.currentIndex++;
        return true;
    }

    public void Print()
    {
        if (this.currentIndex >= this.data.Count)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        Console.WriteLine(this.data[this.currentIndex]);
    }

    public bool HasNext()
    {
        return this.currentIndex + 1 < this.data.Count;
    }

    public IEnumerable<string> PrintAll()
    {
        foreach (var item in this.data)
        {
            yield return item;
        }
    }

    public IEnumerator GetEnumerator()
    {
        return PrintAll().GetEnumerator();
    }
}