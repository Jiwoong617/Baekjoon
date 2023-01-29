using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _14500
    {
        static int[][] map;
        static int[] n;

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            map = new int[n[0]][];
            for(int i = 0; i < n[0]; i++)
                map[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int ans = 0;
            for(int i = 0; i< n[0]; i++)
            {
                for(int j = 0; j< n[1]; j++)
                {
                    int square = Square(i, j);
                    int straight = Straight(i, j);
                    int lmino = Lmino(i, j);
                    int jmino = Jmino(i, j);
                    int smino = Smino(i, j);
                    int zmino = Zmino(i, j);
                    int tmino = Tmino(i, j);

                    ans = Math.Max(Math.Max(Math.Max(square, straight),Math.Max(lmino, jmino)),
                        Math.Max(Math.Max(smino, zmino), Math.Max(ans,tmino)));
                }
            }

            Console.WriteLine(ans);
        }

        static int Square(int x, int y)
        {
            if(x+1 < n[0] && y+1 < n[1])
                return (map[x][y] + map[x + 1][y] + map[x][y + 1] + map[x + 1][y + 1]);

            return 0;
        }

        static int Straight(int x, int y)
        {
            int up = 0;
            int right = 0;
            if (x + 3 < n[0])
                up = map[x][y] + map[x + 1][y] + map[x + 2][y] + map[x + 3][y];

            if (y + 3 < n[1])
                right = map[x][y] + map[x][y + 1] + map[x][y + 2] + map[x][y + 3];

            return Math.Max(up, right);
        }

        static int Lmino(int x, int y)
        {
            int origin = 0;
            int right = 0;
            int up = 0;
            int left = 0;
            if (x + 2 < n[0] && y+1< n[1])
            {
                origin = map[x][y] + map[x + 1][y] + map[x + 2][y] + map[x + 2][y + 1];
                up = map[x][y] + map[x][y + 1] + map[x + 1][y + 1] + map[x + 2][y + 1];
            }
            if (x + 1 < n[0] && y + 2 < n[1])
                right = map[x][y] + map[x][y + 1] + map[x][y + 2] + map[x + 1][y];
            if (x - 1 >= 0 && y + 2 < n[1])
                left = map[x][y] + map[x][y + 1] + map[x][y + 2] + map[x - 1][y + 2];

            return Math.Max(Math.Max(origin, up), Math.Max(right,left));
        }

        static int Jmino(int x, int y)
        {
            int up = 0;
            int right = 0;
            int down = 0;
            int left = 0;
            if (x - 2 >= 0 && y + 1 < n[1])
                up = map[x][y] + map[x][y + 1] + map[x - 1][y + 1] + map[x - 2][y + 1];
            if (x + 2 < n[0] && y + 1 < n[1])
                down = map[x][y] + map[x][y + 1] + map[x + 1][y] + map[x + 2][y];
            if (x + 1 < n[0] && y + 2 < n[1])
            {
                right = map[x][y] + map[x + 1][y] + map[x + 1][y + 1] + map[x + 1][y + 2];
                left = map[x][y] + map[x][y + 1] + map[x][y + 2] + map[x + 1][y + 2];
            }

            return Math.Max(Math.Max(down, up), Math.Max(right, left));
        }

        static int Smino(int x, int y)
        {
            int up = 0;
            int right = 0;
            if (x + 2 < n[0] && y + 1 < n[1])
                up = map[x][y] + map[x + 1][y] + map[x + 1][y + 1] + map[x + 2][y + 1];
            if (x - 1 >= 0 && y + 2 < n[1])
                right = map[x][y] + map[x][y + 1] + map[x - 1][y + 1] + map[x - 1][y + 2];

            return Math.Max(up, right);
        }

        static int Zmino(int x, int y)
        {
            int up = 0;
            int right = 0;
            if (x + 2 < n[0] && y - 1 >= 0)
                up = map[x][y] + map[x + 1][y] + map[x + 1][y - 1] + map[x + 2][y - 1];
            if (x + 1 < n[0] && y + 2 < n[1])
                right = map[x][y] + map[x][y + 1] + map[x + 1][y + 1] + map[x + 1][y + 2];

            return Math.Max(up, right);
        }

        static int Tmino (int x, int y)
        {
            int up = 0;
            int right = 0;
            int down = 0;
            int left = 0;
            if (x - 1 >= 0 && y + 2 < n[1])
                up = map[x][y] + map[x][y + 1] + map[x][y + 2] + map[x - 1][y + 1];
            if (x + 2 < n[0] && y + 1 < n[1])
                right = map[x][y] + map[x + 1][y] + map[x + 2][y] + map[x + 1][y + 1];
            if (x + 1 < n[0] && y + 2 < n[1])
                down = map[x][y] + map[x][y + 1] + map[x][y + 2] + map[x + 1][y + 1];
            if (x + 2 < n[0] && y - 1 >= 0)
                left = map[x][y] + map[x + 1][y] + map[x + 2][y] + map[x + 1][y - 1];

            return Math.Max(Math.Max(up, down), Math.Max(right, left));
        }
    }
}
