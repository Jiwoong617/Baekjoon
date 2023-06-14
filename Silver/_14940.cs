using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _14940
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] map = new int[n[0]][];
            int[][] v = new int[n[0]][];

            Queue<(int, int)> q = new Queue<(int, int)>();
            for(int i = 0; i < n[0]; i++)
            {
                map[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                v[i] = Enumerable.Repeat(-1, n[1]).ToArray();
                for(int j = 0; j < n[1]; j++)
                {
                    if (map[i][j] == 0)
                        v[i][j] = 0;

                    if (map[i][j] == 2)
                    {
                        q.Enqueue((i, j));
                        v[i][j] = 0;
                    }
                }
            }

            int[] ud = { -1, 1, 0, 0 };
            int[] lr = { 0, 0, -1, 1 };
            while (q.Count > 0)
            {
                var t = q.Dequeue();
                for(int i = 0; i<4; i++)
                {
                    int x = t.Item1 + ud[i];
                    int y = t.Item2 + lr[i];
                    if (x < 0 || y < 0 || x >= n[0] || y >= n[1])
                        continue;

                    if (v[x][y] == -1)
                    {
                        q.Enqueue((x,y));
                        v[x][y] = v[t.Item1][t.Item2] + 1;
                    }
                }
            }

            StringBuilder stb = new StringBuilder();
            for(int i = 0; i < n[0]; i++)
                stb.AppendLine(string.Join(" ", v[i]));
            Console.WriteLine(stb);
        }
    }
}
