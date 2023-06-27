using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.silver
{
    internal class _9613
    {
        static int gcd(int a, int b) => b == 0 ? a : gcd(b, a % b);

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0)
            {
                int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                long sum = 0;
                for (int i = 1; i < n.Length; i++)
                    for (int j = i + 1; j < n.Length; j++)
                        sum += gcd(n[i], n[j]);
                Console.WriteLine(sum);
            }
        }
    }
}
