using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _11050
    {
        static void Main(string[] args)
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int sum = 1;
            int div = 1;

            while(a[1] > 0)
            {
                sum *= a[0];
                div *= a[1];
                a[0]--;
                a[1]--;
            }
            Console.WriteLine(sum / div);
        }
    }
}
