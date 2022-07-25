using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1010
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder stb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int sum = 1;

                for (int j = 1; j <= a[0]; j++)
                {
                    sum *= (a[1] - j + 1);
                    sum /= j;
                }
                stb.AppendLine(sum.ToString());
            }

            Console.WriteLine(stb);
        }
    }
}
