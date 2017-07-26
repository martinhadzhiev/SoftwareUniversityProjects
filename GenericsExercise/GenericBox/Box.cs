using System;
using System.Collections.Generic;

public class Box<T> where T : IComparable
{
    private T value;

    public Box(T value)
    {
        this.value = value;
    }

    public T Value
    {
        get { return this.value; }
    }

    public static List<T> SwapElements(List<T> elements, int firstIndex, int secondIndex)
    {
        var firstElement = elements[firstIndex];
        var secondElement = elements[secondIndex];

        elements[secondIndex] = firstElement;
        elements[firstIndex] = secondElement;

        return elements;
    }

    public static int CompareElements(List<T> listOfElements, T element)
    {
        int count = 0;

        foreach (var e in listOfElements)
        {
            if (element.CompareTo(e) == -1)
            {
                count++;
            }
        }

        return count;
    }

    public override string ToString()
    {
        return $"{this.value.GetType().FullName}: {this.value}";
    }
}