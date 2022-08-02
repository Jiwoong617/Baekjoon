using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _11047
    {
        static void Main(string[] args)
        {
            int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] coin = new int[num[0]];
            int use = 0;

            for (int i = 0; i < num[0]; i++)
                coin[i] = int.Parse(Console.ReadLine());

            for(int i = num[0]-1; i>=0; i--)
            {
                use += num[1] / coin[i];
                num[1] %= coin[i];
            }

            Console.WriteLine(use);
        }
    }
}
