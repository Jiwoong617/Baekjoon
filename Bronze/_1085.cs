using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _1085
    {
        static void Main(string[] args)
        {
            int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int x = Math.Min(num[0], num[2] - num[0]);
            int y = Math.Min(num[1], num[3] - num[1]);

            Console.WriteLine(Math.Min(x, y));
        }
    }
}
