using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _6497
    {
        class Road
        {
            public int a;
            public int b;
            public int cost;
            public Road(int a, int b, int cost)
            {
                this.a = a;
                this.b = b;
                this.cost = cost;
            }
        }

        static int[] parent;

        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            while (true)
            {
                parent = Enumerable.Range(0, n[0]).ToArray();

                PriorityQueue<Road, int> pq = new PriorityQueue<Road, int>();
                while (n[1]-- > 0)
                {
                    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    pq.Enqueue(new Road(arr[0], arr[1], arr[2]), arr[2]);
                }

                int ans = 0;
                while (pq.Count > 0)
                {
                    Road line = pq.Dequeue();

                    if (FindP(line.a) == FindP(line.b))
                    {
                        ans += line.cost;
                        continue;
                    }

                    MakeUnion(line.a, line.b);
                }

                stb.AppendLine(ans.ToString());

                n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (n[0] == 0 && n[1] == 0)
                    break;
            }
            Console.WriteLine(stb);
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
