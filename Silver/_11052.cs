using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Silver
{
    internal class _11052
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] sum = new int[n+1];
            for(int i = 1; i<= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    sum[i] = Math.Max(sum[i], sum[i - j] + arr[j-1]);
            }
            //Console.WriteLine(string.Join(' ', sum));
            Console.WriteLine(sum[n]);
        }
    }
}
