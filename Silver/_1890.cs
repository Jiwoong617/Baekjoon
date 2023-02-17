using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Silver
{
    internal class _1890
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] board = new int[n][];
            long[][] count = new long[n][];
            for(int i = 0; i< n; i++)
            {
                board[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                count[i] = new long[n];
            }

            count[0][0] = 1;
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j< n; j++)
                {
                    if (board[i][j] == 0)
                        continue;

                    if (count[i][j] != 0)
                    {
                        int num = board[i][j];
                        if (num + i < n)
                            count[i + num][j]+=count[i][j];

                        if (num + j < n)
                            count[i][j + num] += count[i][j];
                    }
                }
            }

            Console.WriteLine(count[n - 1][n - 1]);
        }
    }
}
