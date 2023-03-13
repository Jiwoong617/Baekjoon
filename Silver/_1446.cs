using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.silver
{
    internal class _1446
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<(int, int)>[] list = new List<(int, int)>[10001];
            for (int i = 0; i < 10001; i++)
                list[i] = new List<(int, int)>();

            for(int i = 0; i < n[0]; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                list[arr[1]].Add((arr[0], arr[2]));
            }

            int[] road = Enumerable.Repeat(120000, n[1] + 1).ToArray();
            road[0] = 0;
            for(int i = 1; i <= n[1]; i++)
            {
                road[i] = Math.Min(road[i],road[i - 1] + 1);

                foreach (var fast in list[i])
                    road[i] = Math.Min(road[i], road[fast.Item1] + fast.Item2);
            }

            Console.WriteLine(road[n[1]]);
        }
    }
}
