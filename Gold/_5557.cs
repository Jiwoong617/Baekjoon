using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.Gold
{
    internal class _5557
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            long[,] count = new long[n, 21];
            count[1,arr[0]] = 1;
            for(int i = 2; i < n; i++)
            {
                for(int j = 0; j<21; j++)
                {
                    if (count[i-1, j] == 0)
                        continue;

                    if (j + arr[i - 1] <= 20)
                        count[i, j + arr[i - 1]] += count[i - 1, j];
                    if (j - arr[i - 1] >= 0)
                        count[i, j - arr[i - 1]] += count[i - 1, j];
                }
            }
            Console.WriteLine(count[n-1, arr[n - 1]]);
        }
    }
}
