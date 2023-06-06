using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _16234
    {
        static int[] n;
        static int[][] map;
        static bool[][] canMove;
        static int[] ud = { -1, 1, 0, 0 };
        static int[] rl = { 0, 0, -1, 1 };

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            map = new int[n[0]][];
            canMove = new bool[n[0]][];
            for(int i = 0; i<n[0]; i++)
            {
                map[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                canMove[i] = new bool[n[0]];
            }

            int day = 0;
            while(true)
            {
                if (!FindUnion())
                    break;
                day++;
            }
            Console.WriteLine(day);
        }

        static bool FindUnion()
        {
            bool flag = false;

            for (int i = 0; i < n[0]; i++)
                canMove[i] = canMove.Select(x => false).ToArray();

            for (int i = 0; i < n[0]; i++)
            {
                for(int j = 0; j < n[0]; j++)
                {
                    if (!canMove[i][j])
                    {
                        if (Moving(i, j))
                            flag = true;
                    }
                }
            }

            return flag;
        }

        static bool Moving(int a, int b)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();
            Queue<(int, int)> move = new Queue<(int, int)>();

            move.Enqueue((a, b));
            q.Enqueue((a, b));
            canMove[a][b] = true;
            int sum = map[a][b];
            while (q.Count> 0)
            {
                (int, int) t = q.Dequeue();

                for(int i = 0; i<4; i++)
                {
                    int x = t.Item1 + ud[i];
                    int y = t.Item2 + rl[i];
                    if(x >= 0 && y >= 0 && x < n[0] && y < n[0] && !canMove[x][y])
                    {
                        if (n[1] <= Math.Abs(map[t.Item1][t.Item2] - map[x][y]) && Math.Abs(map[t.Item1][t.Item2] - map[x][y]) <= n[2])
                        {
                            canMove[x][y] = true;
                            sum += map[x][y];
                            q.Enqueue((x, y));
                            move.Enqueue((x, y));
                        }
                    }
                }
            }

            if (move.Count <= 1)
                return false;

            sum /= move.Count;
            while(move.Count > 0)
            {
                (int,int) t = move.Dequeue();
                map[t.Item1][t.Item2] = sum;
            }

            return true;
        }
    }
}
