using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Silver
{
    internal class _18353
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] sum = Enumerable.Repeat(1,n).ToArray();

            for(int i = 1; i<n; i++)
            {
                for(int j = 0; j<i; j++)
                {
                    if (arr[i] < arr[j])
                        sum[i] = Math.Max(sum[i], sum[j] + 1);
                }
            }
            //Console.WriteLine(string.Join(" ", sum));
            Console.WriteLine(n - sum.Max());
        }
    }
}
