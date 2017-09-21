using System;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        int commandCount = int.Parse(Console.ReadLine());
        LinkedList<int> likedList = new LinkedList<int>();

        for (int i = 0; i < commandCount; i++)
        {
            string[] commandArgs = Console.ReadLine().Split();
            int element = int.Parse(commandArgs[1]);

            if (commandArgs[0] == "Add")
            {
                likedList.Add(element);
            }
            else if(commandArgs[0] == "Remove")
            {
                likedList.Remove(element);
            }
        }

        Console.WriteLine(likedList.Count);

        Console.WriteLine(string.Join(" ",likedList));
    }
}