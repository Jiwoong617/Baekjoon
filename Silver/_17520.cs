using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.silver
{
    class _17520
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
                n /= 2;
            else
                n = n / 2 + 1;
            long sum = 1;
            for (int i = 0; i < n; i++)
                sum = sum*2 % 16769023;
            Console.WriteLine(sum);
        }
    }
}
