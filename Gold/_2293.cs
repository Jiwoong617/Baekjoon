using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _2293
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] coin = new int[n[0]];
            for(int i = 0; i < n[0]; i++)
                coin[i] = int.Parse(Console.ReadLine());

            int[] dp = new int[n[1] + 1];
            dp[0] = 1;
            for(int i = 0; i < n[0]; i++)
            {
                //이전 동전으로 만들 수 있는거 더해줌 됨.
                for(int j = coin[i]; j <= n[1]; j++)
                    dp[j] = dp[j] + dp[j - coin[i]]; 
            }

            Console.WriteLine(dp[n[1]]);
        }
    }
}
