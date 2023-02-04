using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _11055
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr = new int[1];
            arr = arr.Concat(input).ToArray();
            int[] sum = new int[n+1]; sum[0] = 0;

            for(int i = 1; i<=n; i++)
            {
                for (int j = 0; j < i; j++)
                    if (arr[i] > arr[j])
                        sum[i] = Math.Max(sum[i], sum[j] + arr[i]);
            }
            //Console.WriteLine(string.Join(' ', sum));
            Console.WriteLine(sum.Max());
        }
    }
}
