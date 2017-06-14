using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var calculations = input.Split(' ');

            Stack<string> stack = new Stack<string>(calculations.Reverse());

            while (stack.Count() > 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                string op = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());

                if (op == "+")
                {
                    stack.Push((firstNumber+secondNumber).ToString());
                }
                else
                {
                    stack.Push((firstNumber-secondNumber).ToString());

                }
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
