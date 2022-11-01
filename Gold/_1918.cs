using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _1918
    {
        static void Main(string[] args)
        {
            char[] c = Console.ReadLine().ToCharArray();
            List<char> list = new List<char>();
            Stack<char> stack = new Stack<char>();

            for(int i = 0; i<c.Length; i++)
            {
                if (c[i] != '+' && c[i] != '-' && c[i] != '*' && c[i] != '/' && c[i] != '(' && c[i] != ')')
                    list.Add(c[i]);
                else
                {
                    if (c[i] == '(')
                        stack.Push(c[i]);
                    else if (c[i] == '+' || c[i] == '-')
                    {
                        while (stack.Count > 0)
                        {
                            if (stack.Peek() == '(')
                                break;
                            list.Add(stack.Pop());
                        }


                        stack.Push(c[i]);
                    }
                    else if (c[i] == '*' || c[i] == '/')
                    {
                        while (stack.Count > 0)
                        {
                            if (stack.Peek() == '(' || stack.Peek() == '+' || stack.Peek() == '-')
                                break;
                            list.Add(stack.Pop());
                        }

                        stack.Push(c[i]);
                    }
                    else if (c[i] == ')')
                    {
                        while (stack.Count > 0)
                        {
                            if(stack.Peek() == '(')
                            {
                                stack.Pop();
                                break;
                            }
                            list.Add(stack.Pop());
                        }
                    }
                }
            }
            while (stack.Count > 0)
                list.Add(stack.Pop());

            Console.WriteLine(string.Join("", list));
        }
    }
}
