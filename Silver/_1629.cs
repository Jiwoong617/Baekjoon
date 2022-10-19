using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _1629
    {
        static void Main(string[] args)
        {
            long[] n = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            //0 a 1 b 2 c

            Console.WriteLine(mult(n[0], n[1], n[2]));
        }
        static long mult(long a, long b, long c)
        {
            if (b == 1)
                return a % c;

            long sum = mult(a, b / 2, c);

            //모듈러 법칙
            if (b % 2 == 1)
                return (sum * sum % c) * a % c;
            else
                return sum * sum % c;
        }
    }
}
