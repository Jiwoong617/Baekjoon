using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.silver
{
    internal class _1535
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] l = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] j = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[][] health = new int[n + 1][];
            for (int i = 0; i <=n; i++)
                health[i] = new int[100];

            for(int i = 1; i<=n; i++)
            {
                for(int k = 1; k<100; k++)
                {
                    if (l[i - 1] <= k)
                        health[i][k] = Math.Max(health[i - 1][k], health[i - 1][k - l[i - 1]] + j[i - 1]);
                    else
                        health[i][k] = health[i - 1][k];
                }
            }
            Console.WriteLine(health[n][99]);
        }
    }
}
