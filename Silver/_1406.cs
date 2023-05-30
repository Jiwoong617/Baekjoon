using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _1406
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Stack<char> s1 = new Stack<char>();
            for(int i = 0; i<s.Length; i++)
                s1.Push(s[i]);
            Stack<char> s2 = new Stack<char>();
            while(n-- > 0)
            {
                string input = Console.ReadLine();
                switch (input[0])
                {
                    case 'L':
                        if (s1.Count > 0)
                            s2.Push(s1.Pop());
                        break;
                    case 'D':
                        if (s2.Count > 0)
                            s1.Push(s2.Pop());
                        break;
                    case 'B':
                        if (s1.Count > 0)
                            s1.Pop();
                        break;
                    case 'P':
                        s1.Push(input[2]);
                        break;
                }
            }
            while (s1.Count > 0)
                s2.Push(s1.Pop());

            Console.WriteLine(string.Join("", s2));
        }
    }
}
