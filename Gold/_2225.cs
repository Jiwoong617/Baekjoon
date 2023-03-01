using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.Gold
{
    internal class _2225
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            long[,] dp = new long[n[1] + 1, n[0] + 1];
            dp[0, 0] = 1;
            for(int i = 1; i <= n[1]; i++)
            {
                for(int j =0; j <= n[0]; j++)
                {
                    for(int k = 0; k<=j; k++)
                    {
                        dp[i, j] += dp[i - 1, j - k];
                        dp[i, j] %= 1000000000;
                    }
                }
            }
            Console.WriteLine(dp[n[1], n[0]]);
        }
    }
}
