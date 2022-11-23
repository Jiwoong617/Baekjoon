using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _1965
    {
        static int inf = 4000001;
        static void Main(string[] args)
        {
            //0 - 정점, 1 - 간선
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] graph = new int[n[0]+1][];
            for (int i = 1; i <= n[0]; i++)
                graph[i] = Enumerable.Repeat(inf, n[0] + 1).ToArray();

            for(int i = 0; i < n[1]; i++)
            {
                int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[m[0]][m[1]] = m[2];
            }

            //플로이드 - 워셜
            for(int mid = 1; mid <= n[0]; mid++) //거침
            {
                for(int i = 1; i <= n[0]; i++) //출발
                {
                    for(int j = 1; j <= n[0]; j++) //도착
                        graph[i][j] = Math.Min(graph[i][j], graph[i][mid] + graph[mid][j]);
                }
            }

            int ans = inf;
            for(int i = 1; i <= n[0]; i++)
            {
                for(int j =1; j <= n[0]; j++)   
                {
                    if (i == j)
                        continue;

                    if (graph[i][j] != inf && graph[j][i] != inf)
                        ans = Math.Min(ans, graph[i][j] + graph[j][i]);
                }
            }

            if (ans != inf)
                Console.WriteLine(ans);
            else
                Console.WriteLine(-1);
        }
    }
}
