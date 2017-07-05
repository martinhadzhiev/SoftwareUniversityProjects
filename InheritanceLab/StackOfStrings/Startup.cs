using System;

class Startup
{
    static void Main()
    {
        StackOfStrings stack = new StackOfStrings();

        stack.Push("sadasd");
        stack.Push("213123123");
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.IsEmpty());

    }
}