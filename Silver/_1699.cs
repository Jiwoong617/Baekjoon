using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Silver
{
    internal class _1699
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dp = Enumerable.Repeat(100000, n+1).ToArray();
            dp[0] = 0; dp[1] = 1;

            for(int i = 1; i<=n; i++)
            {
                for(int j = 1; j<=Math.Sqrt(i); j++)
                    dp[i] = Math.Min(dp[i], dp[i-j*j]+1);
            }
            //Console.WriteLine(string.Join(" ", dp));
            Console.WriteLine(dp[n]);
        }
    }
}
