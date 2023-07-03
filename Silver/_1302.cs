using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _1302
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, int> d = new SortedDictionary<string, int>();
            while(n-- > 0)
            {
                string s = Console.ReadLine();
                d[s] = d.ContainsKey(s) ? d[s]+1 : 1;
            }
            Console.WriteLine(d.FirstOrDefault(x => x.Value==d.Values.Max()).Key);
        }
    }
}
