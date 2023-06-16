using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _2003
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] sum = new int[n[0]+1];
            for (int i = 1; i <= n[0]; i++)
                sum[i] = sum[i - 1] + arr[i - 1];

            int l = 0;
            int r = 1;
            int count = 0;
            while (r <= n[0])
            {
                if (sum[r] - sum[l] == n[1])
                {
                    count++;
                    l++;
                }
                else if (sum[r] - sum[l] < n[1])
                    r++;
                else
                    l++;
            }
            Console.WriteLine(count);
        }
    }
}
