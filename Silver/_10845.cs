using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _10845
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            Queue<int> q = new Queue<int>();
            while(n-- > 0)
            {
                string[] s = Console.ReadLine().Split();
                switch (s[0])
                {
                    case "push":
                        q.Enqueue(int.Parse(s[1]));
                        break;
                    case "pop":
                        stb = q.Count > 0 ? stb.AppendLine(q.Dequeue().ToString()) : stb.AppendLine("-1");
                        break;
                    case "size":
                        stb.AppendLine(q.Count.ToString());
                        break;
                    case "empty":
                        stb = q.Count == 0 ? stb.AppendLine("1") : stb.AppendLine("0");
                        break;
                    case "front":
                        stb = q.Count > 0 ? stb.AppendLine(q.First().ToString()) : stb.AppendLine("-1");
                        break;
                    case "back":
                        stb = q.Count > 0 ? stb.AppendLine(q.Last().ToString()) : stb.AppendLine("-1");
                        break;
                }
            }
            Console.WriteLine(stb);
        }
    }
}
