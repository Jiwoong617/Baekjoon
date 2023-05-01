using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.Gold
{
    internal class _11758
    {
        static void Main(string[] args)
        {
            int[][] p = new int[3][];
            for (int i = 0; i < 3; i++)
                p[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //ccw공식 (벡터 외적)
            int va = p[0][0] * p[1][1] + p[1][0] * p[2][1] + p[2][0] * p[0][1];
            int vb = p[1][0] * p[0][1] + p[2][0] * p[1][1] + p[0][0] * p[2][1];
            Console.WriteLine(va - vb == 0 ? 0 : (va - vb > 0 ? 1 : -1));
        }
    }
}
