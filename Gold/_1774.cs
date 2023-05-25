using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _1774
    {
        class Khala
        {
            public int a;
            public int b;
            public double len;
            public Khala(int a, int b, double len)
            {
                this.a = a;
                this.b = b;
                this.len = len;
            }
        }

        static int[] parent;

        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            parent = Enumerable.Range(0, n[0]+1).ToArray();
            int[][] point = new int[n[0]+1][];
            for(int i = 1; i <=n[0]; i++)
                point[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            PriorityQueue<Khala, double> pq = new PriorityQueue<Khala, double>();
            for(int i= 1; i <= n[0]; i++)
            {
                for(int j = i+1; j <= n[0]; j++)
                {
                    double dist = Math.Sqrt(Math.Pow(point[i][0] - point[j][0], 2) + Math.Pow(point[i][1] - point[j][1], 2));
                    pq.Enqueue(new Khala(i, j, dist), dist);
                }
            }

            for(int i = 0; i < n[1]; i++)
            {
                int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                MakeUnion(m[0], m[1]);
            }

            double ans = 0;
            while(pq.Count > 0)
            {
                Khala t = pq.Dequeue();

                if (FindP(t.a) == FindP(t.b))
                    continue;

                MakeUnion(t.a, t.b);
                ans += t.len;
            }

            Console.WriteLine($"{ans:.00}");
        }

        static int FindP(int n)
        {
            if (parent[n] == n)
                return n;

            return parent[n] = FindP(parent[n]);
        }

        static void MakeUnion(int a, int b)
        {
            a = FindP(a);
            b = FindP(b);

            if (a == b) return;

            if (a > b)
                parent[a] = b;
            else
                parent[b] = a;
        }
    }
}
