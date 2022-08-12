
using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1932
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            int[,] tree = new int[n,n];
            for (int i = 0; i < n; i++)
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < n; i++)
                tree[n - 1, i] = arr[n - 1][i];

            for(int i = n-2; i>=0; i--)
            {
                for(int j = 0; j<=i; j++)
                {
                    tree[i,j] = arr[i][j] + Math.Max(tree[i + 1,j], tree[i + 1,j + 1]);
                }
            }
            Console.WriteLine(tree[0,0]);
        }
    }
}
