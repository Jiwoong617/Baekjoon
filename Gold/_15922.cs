using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _15922
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int start = arr[0][0];
            int end = arr[0][1];
            long sum = 0;

            //스위핑 알고리즘
            for (int i = 1; i < n; i++)
            {
                if (end < arr[i][0])
                {
                    sum += end - start;
                    end = arr[i][1];
                    start = arr[i][0];
                }
                else
                    end = Math.Max(end, arr[i][1]);
            }

            sum += end - start;
            Console.WriteLine(sum);
        }
    }
}
