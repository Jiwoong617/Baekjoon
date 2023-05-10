using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _9205
    {
        static List<int>[] point;
        static List<(int,int)> distance;
        static bool[] visited;

        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                point = new List<int>[n+2];
                distance = new List<(int,int)>();
                visited = new bool[n+2];

                for(int i = 0; i<n+2; i++)
                {
                    point[i] = new List<int>();
                    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    distance.Add((arr[0], arr[1]));
                }

                for(int i = 0; i<n+2; i++)
                    for(int j = i+1; j<n+2; j++)
                        if (CalDistance(distance[i], distance[j]) <= 1000)
                        {
                            point[i].Add(j);
                            point[j].Add(i);
                        }

                BFS();
                stb.AppendLine(visited[n + 1] ? "happy" : "sad");
            }
            Console.WriteLine(stb);
        }

        static int CalDistance((int,int) a, (int,int) b)
        {
            return Math.Abs(a.Item1- b.Item1) + Math.Abs(a.Item2-b.Item2);
        }

        static void BFS()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(0);
            visited[0] = true;

            while(q.Count > 0)
            {
                int t = q.Dequeue();
                foreach (int next in point[t])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        q.Enqueue(next);
                    }
                }
            }
        }
    }
}
