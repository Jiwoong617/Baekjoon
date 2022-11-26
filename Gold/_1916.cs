using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _1916
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            List<(int, int)>[] graph = new List<(int, int)>[n+1];
            for (int i = 1; i <= n; i++)
                graph[i] = new List<(int, int)>();

            for(int i = 0; i<m; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[arr[0]].Add((arr[1], arr[2]));
            }

            //시작, 종점
            int[] togo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            bool[] visited = new bool[n + 1]; //탐색했는지
            int[] distance = Enumerable.Repeat(100000000, n + 1).ToArray(); //가중치
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>(); //(다음탐색점, 가중치)
            pq.Enqueue(togo[0], 0);
            distance[togo[0]] = 0;

            //다익스트라
            while(pq.Count > 0)
            {
                int point = pq.Dequeue();
                if (!visited[point])
                {
                    visited[point] = true;

                    foreach((int, int) next in graph[point])
                    {
                        distance[next.Item1] = Math.Min(distance[next.Item1], next.Item2 + distance[point]);
                        pq.Enqueue(next.Item1, distance[next.Item1]);
                    }
                }
            }

            Console.WriteLine(distance[togo[1]]);
        }
    }
}
