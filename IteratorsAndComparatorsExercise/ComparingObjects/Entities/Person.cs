using System;
public class Person : IComparable<Person>
{
    public Person(string name, int age, string town)
    {
        this.Name = name;
        this.Age = age;
        this.Town = town;
    }

    private string Name { get; set; }
    private int Age { get; set; }
    private string Town { get; set; }

    public int CompareTo(Person other)
    {
        int result = this.Name.CompareTo(other.Name);

        if (result == 0)
        {
            result = this.Age.CompareTo(other.Age);

            if (result == 0)
            {
                result = this.Town.CompareTo(other.Town);
            }
        }

        return result;
    }
}
