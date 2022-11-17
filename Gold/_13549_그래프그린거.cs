using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _13549
    {
        static void Main(string[] args)
        {
            //n[0] 수빈 위치, n[1] 동생 위치
            int[] n = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();

            List<(int, int)>[] graph = new List<(int, int)>[100001];
            for(int i = 0; i<100001; i++)
            {
                graph[i] = new List<(int, int)>();
                graph[i].Add((i * 2, 0));
                graph[i].Add((i-1, 1));
                graph[i].Add((i+1, 1));
            }
            int[] distance = Enumerable.Repeat(100001, 100001).ToArray();
            bool[] visited = new bool[100001];

            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            distance[n[0]] = 0;
            pq.Enqueue(n[0], 0);

            while (pq.Count > 0)
            {
                int point = pq.Dequeue();
                    
                if (!visited[point])
                {
                    visited[point] = true;

                    foreach ((int, int) p in graph[point])
                    {
                        if (p.Item1 < 100001 && p.Item1 >= 0)
                        {
                            distance[p.Item1] = Math.Min(distance[p.Item1], distance[point] + p.Item2);
                            pq.Enqueue(p.Item1, distance[p.Item1]);

                        }
                    }
                }

            }

            Console.WriteLine(distance[n[1]]);
        }
    }
}
