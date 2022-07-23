using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _3036
    {
        static int gcd(int a, int b) => b == 0 ? a : gcd(b, a % b);

        static void Main(string[] args)
        {
            Console.ReadLine();
            StringBuilder stb = new StringBuilder();
            int[] gear = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 1; i < gear.Length; i++)
                stb.AppendLine($"{gear[0]/gcd(gear[0], gear[i])}/{gear[i] / gcd(gear[0], gear[i])}");

            Console.WriteLine(stb);
        }
    }
}
