using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _1197 //Prim
    {
        static int[] n;
        static bool[] visited;
        static List<(int, long)>[] node;
        static long ans = 0;

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            visited = new bool[n[0] + 1];
            node = new List<(int, long)>[n[0]+1];
            for(int i = 1; i <=n[0];i++)
                node[i] = new List<(int, long)>();

            while (n[1]-- > 0)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                node[arr[0]].Add((arr[1], arr[2]));
                node[arr[1]].Add((arr[0], arr[2]));
            }

            Spanning(1);
            Console.Write(ans);
        }

        static void Spanning(int n)
        {
            PriorityQueue<(int, long), long> pq = new PriorityQueue<(int, long), long>();
            foreach (var value in node[n])
                pq.Enqueue((value.Item1, value.Item2), value.Item2);

            visited[n] = true;
            while(pq.Count > 0)
            {
                var temp = pq.Dequeue();

                if (visited[temp.Item1])
                    continue;

                visited[temp.Item1] = true;
                ans += temp.Item2;
                foreach (var value in node[temp.Item1])
                    if (!visited[value.Item1])
                        pq.Enqueue((value.Item1, value.Item2), value.Item2);
            }
        }
    }
}
