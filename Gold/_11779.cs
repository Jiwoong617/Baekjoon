using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _11779
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            List<(int, int)>[] graph = new List<(int, int)>[n+1];
            for (int i = 1; i <= n; i++)
                graph[i] = new List<(int, int)>();

            for (int i = 0; i<m; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[arr[0]].Add((arr[1], arr[2]));
            }

            int[] startEnd = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] before = new int[n + 1];

            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            int[] distance = Enumerable.Repeat(100000001, n+1).ToArray();
            bool[] visited = new bool[n + 1];
            pq.Enqueue(startEnd[0], 0);
            distance[startEnd[0]] = 0;
            while(pq.Count > 0)
            {
                int p = pq.Dequeue();
                if (!visited[p])
                {
                    visited[p] = true;
                    if (p == startEnd[1])
                        break;

                    foreach((int, int) next in graph[p])
                    {
                        if (distance[p] + next.Item2 < distance[next.Item1])
                        {
                            distance[next.Item1] = distance[p] + next.Item2;
                            pq.Enqueue(next.Item1, distance[next.Item1]);
                            before[next.Item1] = p;
                        }
                    }
                }
            }

            int bus = startEnd[1];
            List<int> list = new List<int>();
            while(bus!= 0)
            {
                list.Add(bus);
                bus = before[bus];
            }

            stb.AppendLine(distance[startEnd[1]].ToString());
            stb.AppendLine(list.Count.ToString());
            for(int i = list.Count-1; i >= 0; i--)
                stb.Append(list[i]+" ");
            Console.WriteLine(stb);
        }
    }
}
