using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Baekjoon.Gold
{
    internal class _4386
    {
        static bool[] visited;
        static List<(int, double)>[] star;
        static double ans;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float[][] pos = new float[n][];
            star = new List<(int, double)>[n];
            visited = new bool[n];
            for(int i = 0; i < n; i++)
            {
                pos[i] = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
                star[i] = new List<(int, double)>();
            }

            for (int i = 0; i < n-1; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    double len = Math.Sqrt(Math.Pow((pos[i][0] - pos[j][0]), 2) + Math.Pow((pos[i][1] - pos[j][1]), 2));
                    star[i].Add((j, len));
                    star[j].Add((i, len));
                }
            }
            Prim(0);
            Console.WriteLine(ans);
        }

        static void Prim(int n)
        {
            //다음, 길이
            PriorityQueue<(int, double), double> pq = new PriorityQueue<(int, double), double>();
            foreach (var next in star[n])
                pq.Enqueue((next.Item1, next.Item2), next.Item2);

            visited[n] = true;
            while(pq.Count > 0)
            {
                var t = pq.Dequeue();

                if (visited[t.Item1])
                    continue;

                visited[t.Item1] = true;
                ans += t.Item2;
                foreach(var i in star[t.Item1])
                    if (!visited[i.Item1])
                        pq.Enqueue((i.Item1, i.Item2), i.Item2);
            }
        }
    }
}
