using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _5397
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int test = int.Parse(Console.ReadLine());
            for(int t = 0; t< test; t++)
            {
                string s = Console.ReadLine();

                Stack<char> pw = new Stack<char>();
                Stack<char> move = new Stack<char>();

                for(int i = 0; i<s.Length; i++)
                {
                    char c = s[i];
                    if (c == '<')
                    {
                        if (pw.Count > 0)
                            move.Push(pw.Pop());
                    }
                    else if (c == '>')
                    {
                        if (move.Count > 0)
                            pw.Push(move.Pop());
                    }
                    else if(c == '-')
                    {
                        if (pw.Count > 0)
                            pw.Pop();
                    }
                    else
                        pw.Push(c);
                }

                List<char> keylog = new List<char>();
                while (move.Count > 0)
                    pw.Push(move.Pop());

                while (pw.Count > 0)
                    keylog.Add(pw.Pop());

                keylog.Reverse();
                stb.AppendLine(string.Join("",keylog));
            }
            Console.WriteLine(stb);
        }
    }
}
