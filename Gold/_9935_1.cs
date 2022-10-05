using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _9935
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            string str = Console.ReadLine();
            string bomb = Console.ReadLine(); //폭탄 문자열

            Stack<char> stack = new Stack<char>();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                stack.Push(str[i]);
                if (stack.Count >= bomb.Length)
                {
                    if (stack.Peek() == bomb[0])
                    {
                        bool isbomb = true;
                        List<char> check = new List<char>();
                        for (int j = 0; j < bomb.Length; j++)
                        {
                            check.Add(stack.Pop());
                            if (check[j] != bomb[j])
                            {
                                isbomb = false;
                                break;
                            }
                        }

                        if (!isbomb)
                        {
                            for (int j = check.Count - 1; j >= 0; j--)
                                stack.Push(check[j]);
                        }
                    }
                }
            }

            if (stack.Count > 0)
                while (stack.Count > 0)
                    stb.Append(stack.Pop());
            else
                stb.AppendLine("FRULA");

            Console.WriteLine(stb);
        }
    }
}
