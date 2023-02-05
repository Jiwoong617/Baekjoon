using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _11048
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] maze = new int[n[0]][];
            int[][] sum = new int[n[0]][];
            for (int i = 0; i < n[0]; i++)
            {
                maze[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                sum[i] = new int[n[1]];
            }
            sum[0][0] = maze[0][0];

            for(int i = 0; i < n[0]; i++)
            {
                for(int j = 0; j < n[1]; j++)
                {
                    if (j - 1 >= 0)
                        sum[i][j] = Math.Max(sum[i][j], maze[i][j] + sum[i][j - 1]);

                    if(i-1 >= 0)
                        sum[i][j] = Math.Max(sum[i][j], maze[i][j] + sum[i-1][j]);

                    if(j - 1 >= 0 && i - 1 >= 0)
                        sum[i][j] = Math.Max(sum[i][j], maze[i][j] + sum[i - 1][j-1]);
                }
            }

            Console.WriteLine(sum[n[0] - 1][n[1] - 1]);
        }
    }
}
