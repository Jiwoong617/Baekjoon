using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _11659
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] sum = new int[n[0]+1];

            for (int i = 1; i <= n[0]; i++)
                sum[i] = arr[i - 1] + sum[i - 1];

            for(int i = 0; i<n[1]; i++)
            {
                int[] slice = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                stb.AppendLine((sum[slice[1]] - sum[slice[0]-1]).ToString());
            }

            Console.WriteLine(stb);
        }
    }
}
