using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _20040
    {
        static int[] p;
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            p = Enumerable.Range(0, n[0]).ToArray();
            for(int i = 1; i <= n[1]; i++)
            {
                int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (Union(m[0], m[1]))
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(0);
        }

        static bool Union(int a, int b)
        {
            a = Findp(a);
            b = Findp(b);
            if (a == b)
                return true;

            if (a > b)
                p[a] = b;
            else
                p[b] = a;
            return false;
        }

        static int Findp(int n)
        {
            if (n == p[n])
                return n;

            p[n] = Findp(p[n]);

            return p[n];
        }
    }
}
