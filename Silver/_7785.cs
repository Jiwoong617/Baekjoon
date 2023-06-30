using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _7785
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, int> dic = new SortedDictionary<string, int>();
            while(n-- > 0)
            {
                string[] s = Console.ReadLine().Split();
                if (s[1] == "enter") dic[s[0]] = 1;
                else dic[s[0]] = 0;
            }
            var arr = dic.Keys.Where(x => dic[x] == 1).ToArray();
            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
    }
}
