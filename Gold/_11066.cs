using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _11066
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int[] sum = new int[n + 1];
                for(int i = 1; i<=n; i++)
                    sum[i] = sum[i - 1] + arr[i-1];

                int[][] file = new int[n + 1][];
                for (int i = 0; i <= n; i++)
                    file[i] = new int[n + 1];

                for(int i = 1; i<=n; i++)
                {
                    for(int j = 1; j+i<=n; j++)
                    {
                        file[j][i + j] = int.MaxValue;
                        for(int k = j; k<i+j; k++)
                            file[j][i+j] = Math.Min(file[j][i + j], file[j][k] + file[k + 1][i + j] + sum[i + j] - sum[j - 1]);
                    }
                }

                //for (int i = 1; i < n; i++)
                //    stb.AppendLine(string.Join(",", file[i] ));

                stb.AppendLine(file[1][n].ToString());
            }
            Console.WriteLine(stb);
        }
    }
}
