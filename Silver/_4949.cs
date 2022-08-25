using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _4949
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();

            while(true)
            {
                string str = Console.ReadLine();
                if (str == ".")
                    break;

                Stack<char> stack = new Stack<char>();
                bool balance = true;

                foreach(char c in str)
                {
                    if (c == '(' || c == '[')
                        stack.Push(c);

                    if (c == ')' || c == ']')
                    {
                        char a;
                        if (stack.Count > 0)
                            a = stack.Pop();
                        else
                        {
                            balance = false;
                            break;
                        }

                        if((c == ')' && a == '[') || (c == ']' && a == '('))
                        {
                            balance = false;
                            break;
                        }
                    }
                }

                if (balance && stack.Count == 0)
                    stb.AppendLine("yes");
                else
                    stb.AppendLine("no");
            }
            Console.WriteLine(stb);
        }
    }
}
