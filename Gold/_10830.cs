using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Gold
{
    class _10830
    {
        static int[,] ans;
        static long[] n;

        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            n = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            int[,] arr = new int[n[0],n[0]];
            ans = new int[n[0], n[0]];

            for(int i = 0; i<n[0]; i++)
            {
                int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0; j < n[0]; j++)
                {
                    arr[i, j] = num[j]% 1000;
                    ans[i, j] = num[j]% 1000;
                }
            }
            n[1] -= 1;

            while(n[1] > 0)
            {
                if (n[1] % 2 == 1)
                    ans = matrix_xegop(ans, arr);

                n[1] /= 2;
                arr = matrix_xegop(arr, arr);
            }

            for(int i = 0; i< n[0]; i++)
            {
                for(int j = 0; j<n[0]; j++)
                {
                    stb.Append($"{ans[i, j]} ");
                }
                stb.AppendLine();
            }

            Console.WriteLine(stb);
        }

        static int[,] matrix_xegop(int[,] arr1, int[,] arr2)
        {
            int[,] temp = new int[n[0], n[0]];

            for(int i = 0; i<n[0]; i++)
            {
                for(int j = 0; j<n[0]; j++)
                {
                    for (int k = 0; k < n[0]; k++)
                        temp[i, j] += arr1[i, k] * arr2[k, j];

                    temp[i, j] %= 1000;
                }
            }

            return temp;
        }
    }
}
