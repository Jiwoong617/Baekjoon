using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1149
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[,] color = new int[n,3];
            //왜 int [][]color 쓰면 오류나는지 모르겠음
            color[0, 0] = arr[0][0]; color[0, 1] = arr[0][1]; color[0, 2] = arr[0][2];
            for(int i = 1; i<n; i++)
            {
                color[i,0] = Math.Min(color[i - 1,1], color[i - 1,2]) + arr[i][0];
                color[i,1] = Math.Min(color[i - 1,2], color[i - 1,0]) + arr[i][1];
                color[i,2] = Math.Min(color[i - 1,1], color[i - 1,0]) + arr[i][2];
            }

            Console.WriteLine(Math.Min(Math.Min(color[n-1,0], color[n-1,1]), color[n-1,2]));
        }
    }
}
