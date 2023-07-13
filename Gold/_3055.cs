using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _3055
    {
        static int[] n;
        static char[][] map;
        static int[][] water;
        static int[][] dochi;
        static (int, int) biber;

        static int[] ud = { -1, 1, 0, 0 };
        static int[] lr = { 0, 0, -1, 1 };

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            map = new char[n[0]][];
            water = new int[n[0]][];
            dochi = new int[n[0]][];

            (int, int) dochiStart = (0, 0);
            Queue<(int, int)> waterPos = new Queue<(int, int)>();
            for(int i = 0; i < n[0]; i++)
            {
                map[i] = Console.ReadLine().ToCharArray();
                water[i] = new int[n[1]];
                dochi[i] = new int[n[1]];
                for(int j = 0; j < n[1]; j++)
                {
                    if (map[i][j] == '*')
                    {
                        waterPos.Enqueue((i, j));
                        water[i][j] = 1;
                    }
                    else if (map[i][j] == 'D') biber = (i, j);
                    else if (map[i][j] == 'S') dochiStart = (i, j);
                }
            }

            WaterBfs(waterPos);
            Console.WriteLine(DochiBfs(dochiStart) ? dochi[biber.Item1][biber.Item2]-1:"KAKTUS");
        }

        static void WaterBfs(Queue<(int,int)> startPos)
        {
            while(startPos.Count>0)
            {
                var temp = startPos.Dequeue();
                for(int i = 0; i<4; i++)
                {
                    int x = temp.Item1 + ud[i];
                    int y = temp.Item2 + lr[i];

                    if (x < 0 || y < 0 || x >= n[0] || y >= n[1]) continue;
                    if (map[x][y] == 'X' || map[x][y] == 'D' || water[x][y] > 0) continue;

                    startPos.Enqueue((x,y));
                    water[x][y] = water[temp.Item1][temp.Item2] + 1;
                }
            }
        }

        static bool DochiBfs((int, int) startPos)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();
            q.Enqueue(startPos);
            dochi[startPos.Item1][startPos.Item2] = 1;

            while(q.Count>0)
            {
                var temp = q.Dequeue();
                if (temp.Item1 == biber.Item1 && temp.Item2 == biber.Item2)
                    return true;

                for (int i = 0; i<4;i++)
                {
                    int x = temp.Item1 + ud[i];
                    int y = temp.Item2 + lr[i];

                    if (x < 0 || y < 0 || x >= n[0] || y >= n[1]) continue;
                    if (map[x][y] == 'X' || dochi[x][y] > 0) continue;
                    if (water[x][y] == 0 || dochi[temp.Item1][temp.Item2] + 1 < water[x][y])
                    {
                        q.Enqueue((x, y));
                        dochi[x][y] = dochi[temp.Item1][temp.Item2] + 1;
                    }
                }
            }

            return false;
        }
    }
}
