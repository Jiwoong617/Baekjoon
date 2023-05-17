using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _14719
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] h = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] arr = new int[n[0]][];
            for (int i = 0; i < n[0]; i++)
                arr[i] = new int[n[1]];

            for(int i = 0; i < n[1]; i++)
            {
                for (int j = 0; j < h[i]; j++)
                    arr[n[0]-1-j][i] = 1;
            }

            int count = 0;
            for (int i = n[0]-1; i>=0; i--)
            {
                for(int j = 1; j < n[1]-1; j++)
                {
                    if (arr[i][j] == 1)
                        continue;

                    if(Array.IndexOf(arr[i][0..j], 1) != -1 && Array.IndexOf(arr[i][j..n[1]], 1) != -1)
                    {
                        arr[i][j] = 2;
                        count++;
                    }
                }
            }

            //for (int i = 0; i < n[0]; i++)
            //    Console.WriteLine(string.Join(" ", arr[i]));
            Console.WriteLine(count);
        }
    }
}
