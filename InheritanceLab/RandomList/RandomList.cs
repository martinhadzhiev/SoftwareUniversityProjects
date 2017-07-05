using System;
using System.Collections;

public class RandomList : ArrayList
{
    public string RandomString()
    {
        Random rnd = new Random();
        var index = rnd.Next(0, this.Count);

        var result = this[index].ToString();
        this.RemoveAt(index);

        return result;
    }
}