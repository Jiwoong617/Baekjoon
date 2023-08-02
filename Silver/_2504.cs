using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.silver
{
    internal class _2504
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            int sum = 0;
            int temp = 1;
            bool flag = true;

            for (int i = 0; i<s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[')
                {
                    stack.Push(s[i]);
                    temp *= s[i] == '(' ? 2 : 3;
                    continue;
                }

                if(stack.Count == 0) { flag = false; break; }

                char c = stack.Pop();
                if (c == '(' && s[i] == ')') // 2
                {
                    if (s[i - 1] == '(')
                    {
                        sum += temp;
                        temp /= 2;
                    }
                    else
                        temp /= 2;
                }
                else if(c == '[' && s[i] == ']') // 3
                {
                    if (s[i - 1] == '[')
                    {
                        sum += temp;
                        temp /= 3;
                    }
                    else
                        temp /= 3;
                }
                else { flag = false; break; }
            }
            if (stack.Count > 0) flag = false;
            Console.WriteLine(flag?sum:0);
        }
    }
}
