namespace CutomList
{
    using System;
    using System.Linq;

    public class Sorter
    {
        public static MyList<T> Sort<T>(MyList<T> customList) where T : IComparable
        {
            MyList<T> sortedList = new MyList<T>();

            customList.Data.OrderBy(a => a).ToList().ForEach(a => sortedList.Add(a));

            return sortedList;
        }
    }
}
