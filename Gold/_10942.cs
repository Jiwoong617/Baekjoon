using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _10942
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int n = int.Parse(sr.ReadLine());
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            bool[,] dp = new bool[n + 1, n + 1];
            for (int i = 1; i <= n; i++) dp[i, i] = true;
            for (int i = 0; i < n - 1; i++) if (arr[i] == arr[i + 1]) dp[i + 1, i + 2] = true;
            for (int i = 2; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j + 1 < n && j + i < n && arr[j] == arr[j + i] && dp[j + 2, j + i])
                        dp[j + 1, j + i + 1] = true;
                }
            }

            int t = int.Parse(sr.ReadLine());
            while(t-->0)
            {
                int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                sw.WriteLine(dp[a[0], a[1]] ? 1 : 0);
            }
            sr.Close();
            sw.Close();
        }
    }
}
