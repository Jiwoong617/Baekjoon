using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Gold
{
    internal class _2294
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] coin = new int[n[0]];
            for(int i = 0; i < n[0]; i++)
                coin[i] = int.Parse(Console.ReadLine());

            int[] money = Enumerable.Repeat(10001, n[1]+1).ToArray();
            money[0] = 0;
            for(int i =0; i < n[0]; i++)
            {
                for(int j = coin[i]; j <= n[1];j++)
                    money[j] = Math.Min(money[j], money[j - coin[i]] + 1);
            }
            Console.WriteLine(money[n[1]] == 10001 ? -1 : money[n[1]]);
        }
    }
}
