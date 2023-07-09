using System;
using System.Collections.Generic;

namespace Baekjoon.silver
{
    internal class _1057
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;
            while (n[1] != n[2])
            {
                n[1] = n[1] % 2 == 0 ? n[1] / 2 : n[1] / 2 + 1;
                n[2] = n[2] % 2 == 0 ? n[2] / 2 : n[2] / 2 + 1;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
