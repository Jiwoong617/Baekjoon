using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _10825
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            List<(string, int, int, int)> l = new List<(string, int, int, int)>();
            while(n-- > 0)
            {
                string[] s = Console.ReadLine().Split();
                l.Add((s[0], int.Parse(s[1]), int.Parse(s[2]), int.Parse(s[3])));
            }

            l = l.OrderByDescending(x => x.Item2).ThenBy(x => x.Item3).ThenByDescending(x => x.Item4).ThenBy(x => x.Item1).ToList();
            foreach (var t in l)
                stb.AppendLine(t.Item1);
            Console.WriteLine(stb);
        }
    }
}
