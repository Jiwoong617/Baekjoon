using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Gold
{
    class _2565
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] elecline = new int[n][];
            int[] sum = Enumerable.Repeat(1, n).ToArray();

            for(int i = 0; i< n; i++)
                elecline[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //정렬
            elecline = elecline.OrderBy(x => x[0]).ToArray();
            /*for (int i = 0; i < n; i++)
                Console.WriteLine(string.Join(" ", elecline[i]));*/

            for(int i = 1; i< n; i++)
            {
                for(int j = 0; j<i; j++)
                {
                    if (elecline[i][1] > elecline[j][1])
                        sum[i] = Math.Max(sum[i], sum[j]+1);
                }
            }
            //Console.WriteLine(string.Join(" ", sum));
            Console.WriteLine(n - sum.Max());
        }
    }
}
