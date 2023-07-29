using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _2133
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] tile = new int[31];
            tile[0] = 1; tile[2] = 3;
            for(int i = 4; i <= n; i++) //2부터 해도됨
            {
                tile[i] = tile[i - 2] * tile[2]; // (i-2)*(2*3)
                for (int j = 4; j <= i; j += 2)
                    tile[i] += tile[i - j] * 2; //특수 모양
            }
            Console.WriteLine(tile[n]);
        }
    }
}
