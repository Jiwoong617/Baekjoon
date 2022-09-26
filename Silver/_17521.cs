using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.silver
{
    class _17521
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            long money = n[1];
            long coin = 0;
            int[] bit = new int[n[0]];
            for (int i = 0; i < n[0]; i++)
                bit[i] = int.Parse(Console.ReadLine());

            int gojum = 0;
            for(int i = 0; i < n[0] - 1; i++)
            {
                if (bit[i] < bit[i + 1])
                {
                    gojum = i + 1;
                    coin += money / bit[i];
                    money = money % bit[i];
                }
                else if (bit[i] > bit[i + 1])
                {
                    money += coin * bit[gojum];
                    coin = 0;
                }
            }
            Console.WriteLine(coin * bit[gojum] + money);
        }
    }
}
