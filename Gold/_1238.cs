using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _1238
    {
        static List<(int, int)>[] graph;
        static int v;

        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            v = n[0];
            int x = n[2];

            graph = new List<(int, int)>[v + 1];
            for (int i = 1; i <= v; i++)
                graph[i] = new List<(int, int)>();

            for (int i = 0; i < n[1]; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[arr[0]].Add((arr[1], arr[2]));
            }


            int ans = 0;
            for(int i = 1; i<= v; i++)
            {
                int go = dijkstra(i, x);
                int back = dijkstra(x, i);

                ans = Math.Max(ans, go + back);
            }

            Console.WriteLine(ans);

        }

        static int dijkstra(int start, int end)
        {
            bool[] visited = new bool[v + 1];

            int[] distance = Enumerable.Repeat(1000001, v + 1).ToArray();
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            pq.Enqueue(start, 0);
            distance[start] = 0;

            while (pq.Count > 0)
            {
                int point = pq.Dequeue();

                if (!visited[point])
                {
                    visited[point] = true;

                    foreach ((int, int) next in graph[point])
                    {
                        distance[next.Item1] = Math.Min(distance[next.Item1], distance[point] + next.Item2);
                        pq.Enqueue(next.Item1, distance[next.Item1]);
                    }
                }
            }

            return distance[end];
        }
    }
}
