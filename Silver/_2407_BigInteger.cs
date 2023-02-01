using System;
using System.Collections.Generic;
using System.Numerics;

namespace BaekJoon.Silver
{
    internal class _2407
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            BigInteger ans = 1;
            BigInteger div = 1;
            for(int i = 0; i< n[1]; i++)
            {
                ans *= n[0] - i;
                div *= i + 1;
            }
            Console.WriteLine(ans / div);
        }
    }
}
