using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _2448
    {
        static char[][] star;
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(Console.ReadLine());
            star = new char[n][];
            for (int i = 0; i < n; i++)
                star[i] = Enumerable.Repeat(' ', 2 * n - 1).ToArray();

            Star(n, 0, n - 1);
            for (int i = 0; i < n; i++)
                sw.WriteLine(string.Join("", star[i]));
            sw.Close();
        }

        static void MakeStar(int x, int y)
        {
            star[x][y] = '*';
            star[x + 1][y + 1] = '*';
            star[x + 1][y - 1] = '*';
            for (int i = y - 2; i < y + 3; i++)
                star[x+2][i] = '*';
        }

        static void Star(int n, int x, int y)
        {
            if (n <= 3)
            {
                MakeStar(x, y);
                return;
            }

            Star(n / 2, x, y);
            Star(n / 2, x + n / 2, y + n / 2);
            Star(n / 2, x + n / 2, y - n / 2);
        }
    }
}
