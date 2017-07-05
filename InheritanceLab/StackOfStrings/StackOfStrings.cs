using System.Collections.Generic;
using System.Linq;

public class StackOfStrings : Stack<string>
{
    private List<string> data;

    public StackOfStrings()
    {
        this.data = new List<string>();
    }

    public void Push(string item)
    {
        this.data.Insert(this.data.Count, item);
    }

    public string Pop()
    {
        var item = this.data.Last();
        this.data.Remove(item);
        return item;
    }

    public string Peek()
    {
        return this.data.Last();
    }

    public bool IsEmpty()
    {
        if (this.data.Count == 0)
        {
            return true;
        }

        return false;
    }
}