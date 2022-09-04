using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1026
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Array.Sort(a);
            Array.Sort(b);
            Array.Reverse(b);
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += (a[i] * b[i]);

            Console.WriteLine(sum);
        }
    }
}
