using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.silver
{
    internal class _2468
    {
        static int n;
        static int[][] map;
        static bool[][] sink;
        static int[] ud = { -1, 1, 0, 0 };
        static int[] lr = { 0, 0, -1, 1 };

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            map = new int[n][];
            sink = new bool[n][];
            int max = 1;
            for (int i = 0; i < n; i++)
            {
                sink[i] = new bool[n];
                map[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                max = Math.Max(max, map[i].Max());
            }

            int ans = 0;
            for (int h = 1; h<=max; h++)
            {
                for(int i = 0; i<n; i++)
                {
                    for(int j = 0; j<n; j++)
                    {
                        sink[i][j] = false;
                        if (map[i][j] < h)
                            sink[i][j] = true;
                    }
                }
                ans = Math.Max(ans,Bfs());
            }
            Console.WriteLine(ans);
        }

        static int Bfs()
        {
            int count = 0;
            Queue<(int, int)> que = new Queue<(int, int)>();

            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    if (sink[i][j])
                        continue;

                    que.Enqueue((i, j));
                    count++;
                    sink[i][j] = true;
                    while(que.Count > 0)
                    {
                        var q = que.Dequeue();
                        for(int t = 0; t<4; t++)
                        {
                            int x = q.Item1 + ud[t];
                            int y = q.Item2 + lr[t];
                            if(x >= 0 && y >= 0 && x<n && y < n && !sink[x][y])
                            {
                                que.Enqueue((x,y));
                                sink[x][y] = true;
                            }
                        }
                    }
                }
            }

            return count;
        }
    }
}
