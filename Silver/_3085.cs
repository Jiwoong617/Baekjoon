using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _3085
    {
        static char[][] candy;
        static int n;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            candy = new char[n][];
            for (int i = 0; i < n; i++)
                candy[i] = Console.ReadLine().ToCharArray();

            int ans = 0;
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j < n-1; j++)
                {
                    (candy[i][j], candy[i][j + 1]) = (candy[i][j + 1], candy[i][j]);
                    ans = Math.Max(ans, Bomboni());
                    (candy[i][j], candy[i][j + 1]) = (candy[i][j + 1], candy[i][j]);
                    (candy[j][i], candy[j + 1][i]) = (candy[j + 1][i], candy[j][i]);
                    ans = Math.Max(ans, Bomboni());
                    (candy[j][i], candy[j + 1][i]) = (candy[j + 1][i], candy[j][i]);
                }
            }

            Console.WriteLine(ans);
        }

        static int Bomboni()
        {
            int hCount = 0;//가로
            int vCount = 0;//세로
            for(int i = 0; i < n; i++)
            {
                int h = 1;
                int v = 1;
                for(int j = 0; j<n-1; j++)
                {
                    if (candy[i][j] == candy[i][j + 1])
                        h++;
                    else
                    {
                        hCount = Math.Max(hCount, h);
                        h = 1;
                    }

                    if (candy[j][i] == candy[j + 1][i])
                        v++;
                    else
                    {
                        vCount = Math.Max(vCount, v);
                        v = 1;
                    }
                }
                hCount = Math.Max(hCount, h);
                vCount = Math.Max(vCount, v);
            }

            return Math.Max(hCount,vCount);
        }
    }
}
