using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.Gold
{
    internal class _2096
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] min = new int[3]; min = (int[])arr[0].Clone();
            int[] max = new int[3]; max = (int[])arr[0].Clone();

            for (int i = 1; i < n; i++)
            {
                int[] tempMin = (int[])min.Clone();
                min[0] = Math.Min(tempMin[0], tempMin[1]) + arr[i][0];
                min[1] = Math.Min(Math.Min(tempMin[0], tempMin[1]), tempMin[2]) + arr[i][1];
                min[2] = Math.Min(tempMin[1], tempMin[2]) + arr[i][2];
                //Console.WriteLine(string.Join(", ", min));

                int[] tempmax = (int[])max.Clone();
                max[0] = Math.Max(tempmax[0], tempmax[1]) + arr[i][0];
                max[1] = Math.Max(Math.Max(tempmax[0], tempmax[1]), tempmax[2]) + arr[i][1];
                max[2] = Math.Max(tempmax[1], tempmax[2]) + arr[i][2];
            }

            Console.WriteLine($"{max.Max()} {min.Min()}");
        }
    }
}
