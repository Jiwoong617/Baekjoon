using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1789
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long num = 1;
            long sum = 1;
            while (sum <= n)
            {
                num++;
                sum += num;
            }
            Console.WriteLine(num-1);
        }
    }
}
