using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Bronze
{
    class _1037
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine(arr.Min() * arr.Max());
        }
    }
}
