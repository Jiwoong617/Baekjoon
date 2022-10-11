using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _1707
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int test = int.Parse(Console.ReadLine());

            for(int t = 0; t<test; t++)
            {
                //ve[0] = 정점, ve[1] = 간선 개수
                int[] ve = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                //그래프
                Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
                for (int i = 1; i <= ve[0]; i++)
                    graph[i] = new List<int>();
                for(int i = 0; i < ve[1]; i++)
                {
                    int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    graph[line[0]].Add(line[1]);
                    graph[line[1]].Add(line[0]);
                }

                Queue<int> que = new Queue<int>();
                int[] check = new int[ve[0] + 1];
                bool is_graph = true;

                //그래프 연결이 안됬을 수도 있으니 전부 탐색
                foreach(int key in graph.Keys)
                {
                    if(check[key] == 0)
                    {
                        que.Enqueue(key);
                        check[key] = 1;

                        while (que.Count > 0)
                        {
                            int point = que.Dequeue();

                            foreach (int p in graph[point])
                            {
                                if (check[p] == 0)
                                {
                                    check[p] = check[point] * (-1);
                                    que.Enqueue(p);
                                }
                                else if (check[p] == check[point])
                                {
                                    is_graph = false;
                                    break;
                                }
                            }
                        }

                    }
                }
                if (is_graph)
                    stb.AppendLine("YES");
                else
                    stb.AppendLine("NO");
            }

            Console.WriteLine(stb);
        }
    }
}
