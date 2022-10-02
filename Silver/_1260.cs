using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1260
    {
        static Dictionary<int, List<int>> graph; //그래프
        static int n; //정점 수
        static int m; //간선 수
        static int v; //시작점
        static bool[] dfs_visit; //dfs 방문표시
        static List<int> dfs_num = new List<int>(); //dfs 방문순서

        static void Main(string[] args)
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = a[0]; m = a[1]; v = a[2];
            graph = new Dictionary<int, List<int>>();
            for (int i = 1; i <= n; i++)
                graph[i] = new List<int>();

            //그래프
            for(int i= 0; i< m; i++)
            {
                int[] point = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[point[0]].Add(point[1]);
                graph[point[1]].Add(point[0]);
            }

            //정렬
            foreach (int key in graph.Keys)
                graph[key].Sort();

            //초기값 설정
            dfs_visit = new bool[n + 1];
            bool[] bfs_visit = new bool[n + 1]; //bfs 방문표시
            List<int> bfs_num = new List<int>(); //bfs 방문순서
            Queue<int> que = new Queue<int>(); //bfs 큐

            dfs(v);

            bfs_visit[v] = true;
            bfs_num.Add(v);
            que.Enqueue(v); //시작점 넣기
            while (que.Count> 0)
            {
                int point = que.Dequeue();
                
                foreach (int p in graph[point])
                {
                    if (!bfs_visit[p])
                    {
                        bfs_visit[p] = true;
                        bfs_num.Add(p);
                        que.Enqueue(p);
                    }

                }
            }
            Console.WriteLine(String.Join(" ", dfs_num));
            Console.WriteLine(String.Join(" ", bfs_num));
        }

        static void dfs(int v)
        {
            dfs_visit[v] = true;
            dfs_num.Add(v);
            
            foreach (int point in graph[v])
            {
                if (!dfs_visit[point])
                    dfs(point);
            }
        }
    }
}
