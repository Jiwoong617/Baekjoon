using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _9251
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int[,] ans = new int[s2.Length + 1, s1.Length + 1];
            for (int i = 0; i < s1.Length + 1; i++)
                ans[0, i] = 0;

            for(int i = 1; i<=s2.Length; i++)
            {
                for(int j = 1; j<=s1.Length; j++)
                {
                    if (s1[j - 1] == s2[i - 1])
                        ans[i, j] = ans[i - 1, j - 1] + 1;
                    else
                        ans[i, j] = Math.Max(ans[i - 1, j], ans[i, j - 1]);
                }
            }

            Console.WriteLine(ans[s2.Length, s1.Length]);
        }
    }
}
