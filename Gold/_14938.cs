using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon.Gold
{
    internal class _14938
    {
        static int[] nmr;
        static int[] item;
        static List<(int, int)>[] graph;

        static void Main(string[] args)
        {
            nmr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            item = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            graph = new List<(int, int)>[nmr[0]];
            for (int i = 0; i < nmr[0]; i++)
                graph[i] = new List<(int, int)>();
            for(int i = 0; i < nmr[2]; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[arr[0]-1].Add((arr[1]-1, arr[2]));
                graph[arr[1]-1].Add((arr[0]-1, arr[2]));
            }

            int ans = 0;
            for (int i = 0; i < nmr[0]; i++)
                ans = Math.Max(ans, Dijkstra(i));
            Console.WriteLine(ans);
        }

        static int Dijkstra(int start)
        {
            int[] distance = Enumerable.Repeat(nmr[1]+1, nmr[0]).ToArray();
            bool[] visited = new bool[nmr[0]];
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>(); //시작점, 가중치

            pq.Enqueue(start, 0);
            distance[start] = 0;
            while(pq.Count > 0)
            {
                int p = pq.Dequeue();
                if (!visited[p])
                {
                    visited[p] = true;
                    foreach((int, int) next in graph[p])
                    {
                        if (distance[p] + next.Item2 <= nmr[1])
                        {
                            distance[next.Item1] = Math.Min(distance[next.Item1], distance[p] + next.Item2);
                            pq.Enqueue(next.Item1, distance[next.Item1]);
                        }
                    }
                }
            }

            int itemCount = 0;
            for(int i = 0; i < nmr[0]; i++)
            {
                if (visited[i])
                    itemCount += item[i];
            }
            return itemCount;
        }
    }
}
