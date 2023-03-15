using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _4883
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            int count = 1;

            while(t != 0)
            {
                int n = t;
                int[][] arr = new int[n][];
                int[][] sum = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    sum[i] = Enumerable.Repeat(100000001, 3).ToArray();
                }
                sum[0][0] = 100000001;
                sum[0][1] = arr[0][1];
                sum[0][2] = Math.Min(arr[0][1], arr[0][1] + arr[0][2]);

                for(int i =1; i < n; i++)
                {
                    sum[i][0] = Math.Min(sum[i - 1][0], sum[i - 1][1]) + arr[i][0];

                    sum[i][1] = Math.Min(Math.Min(sum[i - 1][0], sum[i - 1][1]), sum[i - 1][2]) + arr[i][1];
                    sum[i][1] = Math.Min(sum[i][0] + arr[i][1], sum[i][1]);

                    sum[i][2] = Math.Min(sum[i - 1][1], sum[i - 1][2]) + arr[i][2];
                    sum[i][2] = Math.Min(sum[i][1] + arr[i][2], sum[i][2]);
                }

                stb.AppendLine(count + ". " + sum[n - 1][1]);
                t = int.Parse(Console.ReadLine());
                count++;
            }
            Console.WriteLine(stb);
        }
    }
}
