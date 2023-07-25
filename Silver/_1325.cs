
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _1325
    {
        static int[] n;
        static Dictionary<int, List<int>> com = new();
        static Dictionary<int, int> hack = new();
        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 1; i <= n[0]; i++) com[i] = new List<int>();
            for (int i = 0; i < n[1]; i++)
            {
                int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                com[m[1]].Add(m[0]);
            }

            for (int i = 1; i <= n[0]; i++)
                hack[i] = Bfs(i);

            Console.WriteLine(string.Join(" ",hack.Keys.Where(x => hack[x] == hack.Values.Max())));
        }

        static int Bfs(int start)
        {
            int count = 1;

            bool[] visited = new bool[n[0] + 1];
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            visited[start] = true;

            while (q.Count > 0)
            {
                int t = q.Dequeue();
                foreach (int a in com[t])
                {
                    if (!visited[a])
                    {
                        visited[a] = true;
                        q.Enqueue(a);
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
