using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Silver
{
    internal class _1735
    {
        static long gcd(long a, long b) => b == 0 ? a : gcd(b, a % b);
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            long num = n[0]*m[1] + m[0]*n[1];
            long den = n[1] * m[1];
            long div = gcd(num, den);
            Console.WriteLine($"{num / div} {den / div}");
        }
    }
}
