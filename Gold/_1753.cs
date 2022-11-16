using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _1753
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();

            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int start = int.Parse(Console.ReadLine()); //시작 정점

            //그래프 만들기
            List<(int , int)>[] graph = new List<(int, int)>[n[0]+1]; // graph[출발].(도착, 가중치)
            int[] distance = Enumerable.Repeat(-1, n[0]+1).ToArray(); //시작에서 각 정점으로의 가중치 합(거리)
            bool[] visited = new bool[n[0]+1]; //방문표시

            for (int i = 1; i <= n[0]; i++)
                graph[i] = new List<(int, int)>();

            for(int i = 0; i < n[1]; i++)
            {
                int[] u_v_m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[u_v_m[0]].Add((u_v_m[1], u_v_m[2]));
            }

            //다익스트라
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            pq.Enqueue(start, 0); //시작점, 가중치는 시작 -> 시작이니 0
            distance[start] = 0; //시작 가중치(거리) 0

            while(pq.Count > 0)
            {
                int point = pq.Dequeue();
                if (!visited[point])
                {
                    //방문처리
                    visited[point] = true;

                    //인접한 점들 탐색
                    foreach((int,int) next in graph[point])
                    {
                        //다익스트라는 가중치가 작은거 부터 탐색
                        if (distance[next.Item1] == -1) //-1이면 뭐가 없는거니 현재 + 다음까지 가는 가중치(거리)
                            distance[next.Item1] = distance[point] + next.Item2;
                        else //다음점까지 가중치를 가장 작은 것을 찾기위한 비교, 작은거 넣기
                            distance[next.Item1] = Math.Min(distance[next.Item1], distance[point]+next.Item2);

                        pq.Enqueue(next.Item1, distance[next.Item1]);
                    }
                }
            }

            for(int i = 1; i<= n[0]; i++)
            {
                if (distance[i] == -1)
                    stb.AppendLine("INF");
                else
                    stb.AppendLine(distance[i].ToString());
            }

            Console.WriteLine(stb);
        }
    }
}
