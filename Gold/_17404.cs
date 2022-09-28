using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Gold
{
    class _17404
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] rgb = new int[n][];
            for (int i = 0; i < n; i++)
                rgb[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int ans = int.MaxValue;
            int[,] color = new int[n, 3];
            //0 = 빨강, 1 = 초록, 2 = 파랑
            for (int idx = 0; idx < 3; idx++)
            {
                //시작 고정시키기
                for(int i = 0; i<3; i++)
                {
                    if (i == idx)
                        color[0, i] = rgb[0][i];
                    else
                        color[0, i] = 1001;
                }

                //dp탐색 -> 앞에꺼에서 작은거 + 색
                for (int i = 1; i < n; i++)
                {
                    color[i, 0] = Math.Min(color[i - 1, 1], color[i - 1, 2]) + rgb[i][0];
                    color[i, 1] = Math.Min(color[i - 1, 2], color[i - 1, 0]) + rgb[i][1];
                    color[i, 2] = Math.Min(color[i - 1, 1], color[i - 1, 0]) + rgb[i][2];
                }

                //답 도출
                for(int i = 0; i<3; i++)
                {
                    if (i != idx)
                        ans = Math.Min(ans, color[n - 1, i]);
                }
            }

            Console.WriteLine(ans);
        }
    }
}
