using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _3053
    {
        static void Main(string[] args)
        {
            double num = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.PI * Math.Pow(num,2):.000000}");
            Console.WriteLine($"{Math.Pow(num, 2) * 2:.000000}");
        }
    }
}
