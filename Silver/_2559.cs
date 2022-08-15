using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _2559
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] sum = new int[n[0]+1];
            int[] ans = new int[n[0]-n[1]+1];

            for (int i = 1; i <= n[0]; i++)
                sum[i] = sum[i-1] + arr[i - 1];

            for (int i = 0; i <= n[0]-n[1]; i++)
                ans[i] = sum[i + n[1]] - sum[i];

            Console.WriteLine(ans.Max());
        }
    }
}
