using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _1197
    {
        static int[] parent;

        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            parent = Enumerable.Range(0, n[0] + 1).ToArray();

            PriorityQueue<(int, int, int), int> pq = new PriorityQueue<(int, int, int), int>();
            while (n[1]-- > 0)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                pq.Enqueue((arr[0], arr[1], arr[2]), arr[2]);
            }

            long sum = 0;
            while(pq.Count > 0)
            {
                var temp = pq.Dequeue();
                if (FindP(temp.Item1) == FindP(temp.Item2))
                    continue;

                MakeUnion(temp.Item1, temp.Item2);
                sum += temp.Item3;
            }
            Console.WriteLine(sum);
        }

        static int FindP(int n)
        {
            if (n == parent[n])
                return n;

            return parent[n] = FindP(parent[n]);
        }

        static void MakeUnion(int a, int b)
        {
            a = FindP(a);
            b = FindP(b);

            if (a == b)
                return;

            if (a > b)
                parent[a] = b;
            else
                parent[b] = a;
        }
    }
}
