using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace BaekJoon.Silver
{
    internal class _10826
    {
        static void Main(string[] args)
        {
            BigInteger[] pibo = new BigInteger[10001];
            pibo[1] = 1;
            for (int i = 2; i < 10001; i++)
                pibo[i] = pibo[i - 1] + pibo[i - 2];
            Console.WriteLine(pibo[int.Parse(Console.ReadLine())]);
        }
    }
}
