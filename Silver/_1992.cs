using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _1992
    {
        static int[,] color;
        static StringBuilder stb = new StringBuilder();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            color = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < n; j++)
                    color[i,j] = int.Parse(s[j].ToString());
            }

            find_str(0, 0, n);
            Console.WriteLine(stb);
        }

        static void find_str(int x, int y, int n) //x 위아래, y 왼오
        {
            if (n < 1)
                return;

            bool iszero = true;
            bool isone = true;
            for (int i = x; i < x + n; i++)
            {
                for (int j = y; j < y + n; j++)
                {
                    if (color[i,j] == 1)
                        iszero = false;
                    else
                        isone = false;
                }
            }

            if (isone)
            {
                stb.Append("1");
            }
            else if (iszero)
            {
                stb.Append("0");
            }
            else
            {
                n /= 2;
                stb.Append("(");
                find_str(x, y, n); // 좌측 상
                find_str(x, y + n, n); // 우측 상
                find_str(x + n, y, n); // 좌측 하
                find_str(x + n, y + n, n); // 우측 하
                stb.Append(")");
            }
        }
    }
}
