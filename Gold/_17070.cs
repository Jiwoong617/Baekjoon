using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Gold
{
    internal class _17070
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] home = new int[n][];
            for (int i = 0; i < n; i++)
                home[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int count = 0;
            Queue<(int, int, int)> que = new Queue<(int, int, int)>(); //0-우 1-대각 2-하
            que.Enqueue((0, 1, 0));
            while(que.Count > 0)
            {
                var p = que.Dequeue();
                int x = p.Item1;
                int y = p.Item2;
                int dir = p.Item3;

                if (x == n - 1 && y == n - 1)
                {
                    count++;
                    continue;
                }

                if (x + 1 < n && y + 1 < n)
                    if (home[x + 1][y] == 0 && home[x + 1][y + 1] == 0 && home[x][y + 1] == 0)
                        que.Enqueue((x + 1, y + 1, 1));

                switch (dir)
                {
                    case 0:
                        if (y + 1 < n && home[x][y + 1] == 0)
                            que.Enqueue((x, y + 1, 0));
                        break;
                    case 1:
                        if (y + 1 < n && home[x][y + 1] == 0)
                            que.Enqueue((x, y + 1, 0));
                        if (x + 1 < n && home[x+1][y] == 0)
                            que.Enqueue((x+1, y, 2));
                        break;
                    case 2:
                        if (x + 1 < n && home[x+1][y] == 0)
                            que.Enqueue((x+1, y, 2));
                        break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
