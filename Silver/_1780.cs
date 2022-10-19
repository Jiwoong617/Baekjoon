using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _1780
    {
        static int one = 0;
        static int zero = 0;
        static int m_one = 0;
        static int[][] paper;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            paper = new int[n][];
            for (int i = 0; i < n; i++)
                paper[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            find_num(0, 0, n);
            Console.WriteLine($"{m_one}\n{zero}\n{one}");
        }

        static void find_num(int x, int y, int n) //x 위아래, y 왼오
        {
            if (n < 1)
                return;

            bool isone = true;
            bool iszero = true;
            bool ism_one = true;

            for (int i = x; i < x + n; i++)
            {
                for (int j = y; j < y + n; j++)
                {
                    if (paper[i][j] == 1)
                    {
                        iszero = false;
                        ism_one = false;
                    }
                    else if (paper[i][j] == 0)
                    {
                        isone = false;
                        ism_one = false;
                    }
                    else
                    {
                        iszero = false;
                        isone = false;
                    }
                }
            }

            if (isone)
                one++;
            else if (iszero)
                zero++;
            else if (ism_one)
                m_one++;
            else
            {
                // 1 2 3
                // 4 5 6
                // 7 8 9
                n /= 3;
                find_num(x, y, n); // 1
                find_num(x, y+n, n); // 2
                find_num(x, y+n*2, n); // 3
                find_num(x+n, y, n); // 4
                find_num(x+n, y+n, n); // 5
                find_num(x+n, y+n*2, n); // 6
                find_num(x+n*2, y, n); // 7
                find_num(x+n*2, y+n, n); // 8
                find_num(x+n*2, y+n*2, n); // 9
            }
        }
    }
}
