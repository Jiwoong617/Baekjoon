using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _2167
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] arr = new int[n[0]][];
            for(int i = 0; i < n[0]; i++)
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[,] sum = new int[n[0] + 1, n[1] + 1];
            for(int i =1; i <= n[0]; i++)
            {
                for (int j = 1; j <= n[1]; j++)
                    sum[i, j] = sum[i - 1, j] + sum[i, j - 1] - sum[i - 1, j - 1] + arr[i - 1][j - 1];
            }

            int t = int.Parse(Console.ReadLine());
            StringBuilder stb = new StringBuilder();
            while (t-- > 0)
            {
                int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                stb.AppendLine($"{sum[m[2], m[3]] - sum[m[0]-1,m[3]] - sum[m[2],m[1]-1] + sum[m[0] - 1, m[1]-1]}");
            }
            Console.WriteLine(stb);
        }
    }
}
