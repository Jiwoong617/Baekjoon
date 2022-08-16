using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _11660
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] arr = new int[n[0]][];
            for (int i = 0; i < n[0]; i++)
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[,] sum = new int[n[0],n[0]+1];
            for(int i = 0; i<n[0]; i++)
            {
                for(int j = 1; j<=n[0]; j++)
                    sum[i, j] = sum[i, (j - 1)] + arr[i][j-1];
            }

            for(int i = 0; i<n[1]; i++)
            {
                int ans = 0;
                int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j = m[0]-1; j<m[2]; j++)
                {
                    ans += (sum[j,m[3]] - sum[j,m[1]-1]);
                }
                stb.AppendLine(ans.ToString());
            }

            Console.WriteLine(stb);
        }
    }
}
