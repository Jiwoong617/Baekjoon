using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _1926
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] p = new int[n[0]][];
            for(int i = 0; i < n[0]; i++)
                p[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int count = 0;
            int area = 0;
            int[] ud = { -1, 1, 0, 0 };
            int[] rl = { 0, 0, -1, 1 };
            Queue<(int, int)> q = new Queue<(int, int)>();
            for(int i = 0; i < n[0]; i++)
            {
                for(int j = 0; j < n[1]; j++)
                {
                    if (p[i][j] == 0) continue;

                    count++;
                    int size = 1;
                    p[i][j] = 0;
                    q.Enqueue((i, j));
                    while(q.Count > 0)
                    {
                        var t = q.Dequeue();
                        for(int k = 0; k<4; k++)
                        {
                            int x = t.Item1 + ud[k];
                            int y = t.Item2 + rl[k];
                            if(x >= 0 && y >= 0 && x < n[0] && y < n[1] && p[x][y] == 1)
                            {
                                q.Enqueue((x, y));
                                p[x][y] = 0;
                                size++;
                            }
                        }
                    }
                    area = Math.Max(area, size);
                }
            }

            Console.WriteLine($"{count}\n{area}");
        }
    }
}
