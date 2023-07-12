using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _2206
    {
        static int[] n;
        static int[][] map;
        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            map = new int[n[0]][];
            for (int i = 0; i < n[0]; i++)
                map[i] = Console.ReadLine().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();

            Console.WriteLine(Bfs());
        }

        static int Bfs()
        {
            int[] ud = { -1, 1, 0, 0 };
            int[] lr = { 0, 0, -1, 1 };

            int[,,] visited = new int[n[0], n[1], 2]; //x, y, 파괴 여부(0 - 안부숨, 1 - 부숨)
            visited[0, 0, 0] = 1;
            Queue<(int, int, int)> q = new Queue<(int, int, int)>();
            q.Enqueue((0, 0, 0));

            while(q.Count > 0)
            {
                var t = q.Dequeue();
                if (t.Item1 == n[0] - 1 && t.Item2 == n[1] - 1)
                    return visited[t.Item1, t.Item2, t.Item3];

                for (int i = 0; i < 4; i++)
                {
                    int x = t.Item1 + ud[i];
                    int y = t.Item2 + lr[i];

                    if (x < 0 || y < 0 || x >= n[0] || y >= n[1]) continue;
                    if (visited[x,y,t.Item3] > 0) continue;

                    if (map[x][y] == 0)
                    {
                        visited[x, y, t.Item3] = visited[t.Item1, t.Item2, t.Item3] + 1;
                        q.Enqueue((x, y, t.Item3));
                    }
                    if(t.Item3 == 0 && map[x][y] == 1)
                    {
                        visited[x, y, 1] = visited[t.Item1, t.Item2, t.Item3] + 1;
                        q.Enqueue((x, y, 1));
                    }
                }
            }

            return -1;
        }
    }
}
