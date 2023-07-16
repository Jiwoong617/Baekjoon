using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Silver
{
    internal class _11652
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<long, int> d = new SortedDictionary<long, int>();
            while(n-- > 0)
            {
                long a = long.Parse(Console.ReadLine());
                d[a] = d.ContainsKey(a) ? d[a] + 1 : 1;
            }
            Console.WriteLine(d.FirstOrDefault(x => x.Value == d.Values.Max()).Key);
        }
    }
}
