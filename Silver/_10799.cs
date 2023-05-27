using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _10799
    {
        static void Main(string[] args)
        {
            string p = Console.ReadLine();
            Stack<char> s = new Stack<char>();
            int ans = 0;
            for(int i = 0; i<p.Length; i++)
            {
                if (p[i] == '(')
                    s.Push(p[i]);
                else
                {
                    if (p[i - 1] == '(')
                        ans += s.Count-1;
                    else
                        ans++;

                    s.Pop();
                }
            }
            Console.WriteLine(ans);
        }
    }
}
