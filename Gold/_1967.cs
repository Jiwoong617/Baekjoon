using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _1967
    {
        static int n;
        static List<(int, int)>[] graph;
        static int[] distance;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            graph = new List<(int, int)>[n+1];
            for (int i = 1; i <= n; i++)
                graph[i] = new List<(int, int)>();

            for(int i = 0; i<n-1; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[arr[0]].Add((arr[1], arr[2]));
                graph[arr[1]].Add((arr[0], arr[2]));
            }

            distance = Enumerable.Repeat(-1, n+1).ToArray();
            distance[1] = 0;
            Dfs(1, 0);

            int max = Array.IndexOf(distance, distance.Max());
            distance = Enumerable.Repeat(-1, n + 1).ToArray();
            distance[max] = 0;
            Dfs(max, 0);

            Console.WriteLine(distance.Max());
        }

        static void Dfs(int n, int dis)
        {
            foreach((int,int) next in graph[n])
            {
                if (distance[next.Item1] == -1)
                {
                    distance[next.Item1] = dis + next.Item2;
                    Dfs(next.Item1, distance[next.Item1]);
                }
            }
        }
    }
}
