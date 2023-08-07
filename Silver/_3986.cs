using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon.silver
{
    internal class _3986
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while(n-- > 0)
            {
                string s = Console.ReadLine();
                if (s.Length % 2 == 1)
                    continue;

                Stack<char> stack = new Stack<char>();
                for(int i = 0; i< s.Length; i++)
                {
                    if (stack.Count == 0)
                        stack.Push(s[i]);
                    else
                    {
                        char c = stack.Peek();
                        if (c == s[i])
                            stack.Pop();
                        else
                            stack.Push(s[i]);
                    }
                }
                if (stack.Count == 0) count++;
            }
            Console.WriteLine(count);
        }
    }
}
