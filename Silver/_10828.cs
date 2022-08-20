using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _10828
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            StringBuilder stb = new StringBuilder();

            for(int i = 0; i<n; i++)
            {
                string[] a = Console.ReadLine().Split();
                string s;
                int num;
                if (a.Length > 1)
                {
                    s = a[0];
                    num = int.Parse(a[1]);
                }
                else
                {
                    s = a[0];
                    num = 0;
                }

                switch (s)
                {
                    case "push":
                        stack.Push(num);
                        break;
                    case "pop":
                        if (stack.Count == 0)
                            stb.AppendLine("-1");
                        else
                            stb.AppendLine(stack.Pop().ToString());
                        break;
                    case "size":
                        stb.AppendLine(stack.Count.ToString());
                        break;
                    case "empty":
                        if (stack.Count == 0)
                            stb.AppendLine("1");
                        else
                            stb.AppendLine("0");
                        break;
                    case "top":
                        if (stack.Count == 0)
                            stb.AppendLine("-1");
                        else
                            stb.AppendLine(stack.Peek().ToString());
                        break;
                }
            }

            Console.WriteLine(stb);
        }
    }
}
