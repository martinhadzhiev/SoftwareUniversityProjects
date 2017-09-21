using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Lake : IEnumerable<int>
{
    private readonly IList<int> stones;

    public Lake(params int[] stones)
    {
        this.stones = new List<int>(stones);
    }

    public IEnumerator<int> GetEnumerator()
    {
        List<int> evenStones = new List<int>();
        List<int> oddStones = new List<int>();

        int count = 0;
        foreach (var stone in this.stones)
        {
            if (count % 2 ==0)
            {
                evenStones.Add(stone);
            }
            else
            {
                oddStones.Insert(0,stone);
            }
            count++;
        }

        foreach (var evenStone in evenStones)
        {
            yield return evenStone;
        }

        foreach (var oddStone in oddStones)
        {
            yield return oddStone;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}