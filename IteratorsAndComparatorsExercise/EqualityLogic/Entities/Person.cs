using System;
public class Person : IEquatable<Person>, IComparable<Person>
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; private set; }
    public int Age { get; private set; }

    public override string ToString()
    {
        return $"{this.Name} {this.Age}";
    }

    public bool Equals(Person other)
    {
        if (this.Name == other.Name && this.Age == other.Age)
        {
            return true;
        }

        return false;
    }

    public override int GetHashCode()
    {
        int result = 0;

        foreach (char c in this.Name)
        {
            result += c;
        }

        result += this.Age;

        return result;
    }

    public int CompareTo(Person other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
        if (nameComparison != 0) return nameComparison;
        return Age.CompareTo(other.Age);
    }
}