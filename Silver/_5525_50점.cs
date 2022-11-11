using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _5525
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int len = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string io = string.Concat(Enumerable.Repeat("IO", n)) + "I";
            //Console.WriteLine(io);

            int iolen = io.Length;
            int ans = 0;
            for(int i = 0; i<len-iolen; i++)
            {
                string s2 = s.Substring(i, iolen);
                if (s2 == io)
                    ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
