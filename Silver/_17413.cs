using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _17413
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            string s = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            for(int i = 0; i<s.Length; i++)
            {
                if (s[i] =='<')
                {
                    while (stack.Count > 0)
                        stb.Append(stack.Pop());

                    while (s[i] != '>')
                    {
                        stb.Append(s[i]);
                        i++;
                    }
                    stb.Append(s[i]);
                }
                else if (s[i] == ' ')
                {
                    while (stack.Count > 0)
                        stb.Append(stack.Pop());
                    stb.Append(' ');
                }
                else
                    stack.Push(s[i]);
            }

            while (stack.Count > 0)
                stb.Append(stack.Pop());
            Console.WriteLine(stb);
        }
    }
}
