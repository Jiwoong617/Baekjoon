using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _17626
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dp = new int[n + 1];
            dp[1] = 1;

            for(int i = 1; i<=n; i++)
            {
                dp[i] = dp[i-1]+1;//이전거 + 1
                for(int j = 2; j*j<=i; j++)
                    dp[i] = Math.Min(dp[i], dp[i-(j*j)] + 1); //제곱(1) + (수-제곱) 비교
            }

            Console.WriteLine(dp[n]);
        }
    }
}
