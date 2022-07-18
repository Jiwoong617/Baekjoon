using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _3009
    {
        static void Main(string[] args)
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] d = new int[2];

            for(int i = 0; i<2; i++)
            {
                if (a[i] == b[i])
                    d[i] = c[i];
                else if (a[i] == c[i])
                    d[i] = b[i];
                else
                    d[i] = a[i];

                Console.Write(d[i] + " ");
            }
        }
    }
}
