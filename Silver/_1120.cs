using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _1120
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int ans = int.MaxValue;
            for (int i = 0; i <= s[1].Length - s[0].Length; i++)
            {
                int count = 0;
                for (int j = 0; j < s[0].Length; j++)
                    if (s[0][j] != s[1][i + j]) count++;
                ans = Math.Min(ans, count);
            }
            Console.WriteLine(ans);
        }
    }
}
