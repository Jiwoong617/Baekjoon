using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Bronze
{
    class _1934
    {
        static int gcd(int a, int b) => b == 0 ? a : gcd(b, a%b);

        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            StringBuilder stb = new StringBuilder();

            for(int i = 0; i<n; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int a = arr.Max();
                int b = arr.Min();

                stb.AppendLine((a * b / gcd(a, b)).ToString());
            }
            Console.WriteLine(stb);
        }
    }
}
