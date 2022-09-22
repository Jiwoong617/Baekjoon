using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _20044
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);
            int[] sum = new int[n];
            for (int i = 0; i < sum.Length; i++)
                sum[i] = arr[i] + arr[n*2-i-1];

            Console.WriteLine(sum.Min());
        }
    }
}
