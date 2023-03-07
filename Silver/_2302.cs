using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.silver
{
    internal class _2302
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[] dp = new int[41];
            dp[0] = 1; dp[1] = 1; dp[2] = 2;
            for(int i = 3; i<=n; i++)
                dp[i] = dp[i - 1] + dp[i-2];

            int sum = 1;
            int pre = 0;
            while(m-- > 0)
            {
                int vip = int.Parse(Console.ReadLine());
                sum *= dp[vip - pre - 1];
                pre = vip;
            }
            Console.WriteLine(sum * dp[n - pre]);
        }
    }
}
