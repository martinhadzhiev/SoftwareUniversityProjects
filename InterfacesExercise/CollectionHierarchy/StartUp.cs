using System;
using System.Text;

class StartUp
{
    static void Main()
    {
        IAddCollection<string> addCollection = new AddCollection<string>();
        IAddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();
        IMyList<string> myList = new MyList<string>();

        var input = Console.ReadLine().Trim().Split();
        int removeCmds = int.Parse(Console.ReadLine());

        var collection0 = new StringBuilder();
        var collection1 = new StringBuilder();
        var collection2 = new StringBuilder();

        foreach (var s in input)
        {
            collection0.Append(addCollection.Add(s)+" ");
            collection1.Append(addRemoveCollection.Add(s)+" ");
            collection2.Append(myList.Add(s)+" ");
        }

        Console.WriteLine(collection0.ToString().Trim());
        Console.WriteLine(collection1.ToString().Trim());
        Console.WriteLine(collection2.ToString().Trim());

        for (int i = 0; i < removeCmds; i++)
        {
            Console.Write(addRemoveCollection.Remove()+" ");
        }
        Console.WriteLine();

        for (int i = 0; i < removeCmds; i++)
        {
            Console.Write(myList.Remove()+" ");
        }
        Console.WriteLine();
    }
}