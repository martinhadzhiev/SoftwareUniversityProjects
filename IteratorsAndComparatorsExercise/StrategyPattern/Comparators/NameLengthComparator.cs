using System.Collections.Generic;
using System.Linq;

public class NameLengthComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        int result = x.Name.Length.CompareTo(y.Name.Length);

        if (result == 0)
        {
            char xFirstLetter = x.Name.ToLower().First();
            char yFirstLetter = y.Name.ToLower().First();

            result = xFirstLetter.CompareTo(yFirstLetter);
        }

        return result;
    }
}