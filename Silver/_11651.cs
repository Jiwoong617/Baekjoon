using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _11651
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[][] arr = new int[num][];
            int[] a = new int[1];
            for (int i = 0; i < num; i++)
            {
                int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                arr[i] = n;
            }

            var sorted = arr.OrderBy(x => x[1]).ThenBy(x => x[0]).ToArray();

            StringBuilder stb = new StringBuilder();
            for (int i = 0; i < num; i++)
                stb.AppendLine($"{sorted[i][0]} {sorted[i][1]}");
            Console.WriteLine(stb);
        }
    }
}
