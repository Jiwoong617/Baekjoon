using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _2573
    {
        static int[] n;
        static int[][] ice;
        static bool[][] visited;
        static long year = 0;

        static int[] ud = { -1, 1, 0, 0 };
        static int[] lr = { 0, 0, -1, 1 };

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            ice = new int[n[0]][];
            visited = new bool[n[0]][];
            for(int i = 0; i < n[0]; i++)
                ice[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            while (true)
            {
                for(int i = 0; i < n[0]; i++)
                    visited[i] = Enumerable.Repeat(false, n[1]).ToArray();

                Check(true);

                for(int i = 0; i < n[0]; i++)
                    for(int j = 0; j < n[1]; j++)
                        if (ice[i][j] == 0 && !visited[i][j])
                            IceBfs(i, j);

                year++;

                int c = Check(false);
                if (c == 0)
                {
                    Console.WriteLine(0);
                    return;
                }
                else if(c >= 2)
                {
                    Console.WriteLine(year);
                    return;
                }
            }
        }

        static void IceBfs(int a, int b)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();
            q.Enqueue((a, b));
            visited[a][b] = true;

            while(q.Count > 0)
            {
                var t = q.Dequeue();
                for(int i = 0; i < 4; i++)
                {
                    int x = t.Item1 + ud[i];
                    int y = t.Item2 + lr[i];

                    if (x < 0 || y < 0 || x >= n[0] || y >= n[1]) continue;
                    if (ice[x][y] > 0)
                        ice[x][y]--;
                    else
                    {
                        if (visited[x][y]) continue;
                        else
                        {
                            visited[x][y] = true;
                            q.Enqueue((x, y));
                        }
                    }
                }
            }
        }

        static int Check(bool check)
        {
            int count = 0;
            for(int i = 0; i < n[0]; i++)
            {
                for(int j= 0; j< n[1]; j++)
                {
                    if (ice[i][j] == 0 || visited[i][j] == check) continue;

                    count++;
                    Queue<(int, int)> q = new Queue<(int, int)>();
                    q.Enqueue((i, j));
                    visited[i][j] = check;

                    while(q.Count > 0)
                    {
                        var t = q.Dequeue();
                        for (int k = 0; k < 4; k++)
                        {
                            int x = t.Item1 + ud[k];
                            int y = t.Item2 + lr[k];

                            if (x < 0 || y < 0 || x >= n[0] || y >= n[1]) continue;
                            if (visited[x][y] == !check && ice[x][y] > 0)
                            {
                                visited[x][y] = check;
                                q.Enqueue((x, y));
                            }
                        }
                    }
                }
            }

            return count;
        }
    }
}
