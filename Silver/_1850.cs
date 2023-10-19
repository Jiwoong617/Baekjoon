using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _1850
    {
        static long gcd(long a, long b) => b == 0 ? a : gcd(b, a % b);

        static void Main(string[] args)
        {
            long[] n = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long m = gcd(n.Max(), n.Min());
            Console.WriteLine(new string('1', (int)m));
        }
    }
}
