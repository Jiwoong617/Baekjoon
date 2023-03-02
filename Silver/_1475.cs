using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.silver
{
    internal class _1475
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[] num = new int[9];

            for(int i = 0; i<s.Length; i++)
            {
                int n = int.Parse(s[i].ToString());
                if(n == 9)
                {
                    num[6]++;
                    continue;
                }
                num[n]++;
            }

            int ans = 0;
            for(int i = 0; i<9; i++)
            {
                if (i == 6)
                    ans = Math.Max(ans, (num[i] + 1) / 2);
                else
                    ans = Math.Max(ans, num[i]);
            }

            Console.WriteLine(ans);
        }
    }
}
