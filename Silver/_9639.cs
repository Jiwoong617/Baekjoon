using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon
{
    class _9639
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            for(int test = 0; test<t; test++)
            {
                int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int[][] arr = new int[n[0]][];
                for(int i = 0; i < n[0]; i++)
                    arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                //누적합
                long[,] sum = new long[n[0]+1, n[1]+1];
                for(int i = 1; i <= n[0]; i++)
                {
                    for (int j = 1; j <= n[1]; j++)
                        sum[i, j] = arr[i - 1][j - 1] + sum[i, j - 1] + sum[i - 1, j] - sum[i-1,j-1];
                }

                long max = sum[n[0],n[1]];
                for(int i = 0; i < n[0]; i++)
                {
                    for(int j = 0; j < n[1]; j++)
                    {
                        if (max < sum[n[0], n[1]] - sum[i, n[1]] - sum[n[0], j] + sum[i, j])
                            max = sum[n[0], n[1]] - sum[i, n[1]] - sum[n[0], j] + sum[i, j];
                    }
                }

                stb.AppendLine(max.ToString());
            }

            Console.WriteLine(stb);
        }
    }
}
