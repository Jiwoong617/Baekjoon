using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _23247
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] arr = new int[n[0]][];
            int count = 0;

            for (int i = 0; i < n[0]; i++)
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //누적 합
            int[,] sum = new int[n[0] + 1, n[1] + 1];
            for (int i = 1; i <= n[0]; i++)
            {
                for (int j = 1; j <= n[1]; j++)
                    sum[i, j] = sum[i, (j - 1)] + arr[i - 1][j - 1] + sum[i - 1, j] - sum[i - 1, j - 1];
            }

            /*
            Console.WriteLine();
            for (int i = 1; i <= n[0]; i++)
            {
                for (int j = 1; j <= n[1]; j++)
                    Console.Write(sum[i, j] + " ");
                Console.WriteLine();
            }

            */

            //시작 범위
            for (int i = 1; i <= n[0]; i++)
            {
                for (int j = 1; j <= n[1]; j++)
                {
                    //끝 범위
                    for (int ii = 0; ii < 10; ii++)
                    {
                        for (int jj = 0; jj < 10; jj++)
                        {
                            if(i+ii <= n[0] && j+jj <= n[1])
                            {
                                 if (sum[i+ii, j+jj] - sum[i + ii, j -1] - sum[i - 1, j + jj] + sum[i - 1, j - 1] == 10)
                                {
                                    //Console.WriteLine($"{sum[i+ii, j+jj]} - {sum[i + ii, j -1]} - {sum[i - 1, j + jj]} + {sum[i - 1, j - 1]}");
                                    count++;
                                }
                            }

                        }
                    }
                }
            }
            
            Console.WriteLine(count);
        }
    }
}
