using System.Collections.Generic;
using System.Linq;

namespace BalancedParanthesis
{
    using System;

    class BalancedParanthesis
    {
        static void Main()
        {
            var paranthesisLine = Console.ReadLine();

            var openedParanthesis = new Stack<char>();
            var openingCases = new char[] { '(', '{', '[' };

            for (int i = 0; i < paranthesisLine.Length; i++)
            {
                if (openingCases.Contains(paranthesisLine[i]))
                {
                    openedParanthesis.Push(paranthesisLine[i]);
                }
                else
                {
                    if (openedParanthesis.Count != 0)
                    {
                        switch (paranthesisLine[i])
                        {
                            case '}':
                                if (openedParanthesis.Pop() != '{')
                                {
                                    Console.WriteLine("NO");
                                    return;
                                }
                                break;

                            case ')':
                                if (openedParanthesis.Pop() != '(')
                                {
                                    Console.WriteLine("NO");
                                    return;
                                }
                                break;

                            case ']':
                                if (openedParanthesis.Pop() != '[')
                                {
                                    Console.WriteLine("NO");
                                    return;
                                }
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                        
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
