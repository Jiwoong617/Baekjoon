using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _9084
    {
        static void Main(string[] args)
        {
            StringBuilder stb= new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] coin = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int amount = int.Parse(Console.ReadLine());

                int[] money = new int[10001];
                money[0] = 1; //없으면 0나옴

                for(int i = 0; i<n; i++)
                {
                    for (int j = coin[i]; j <= amount; j++)
                        money[j] += money[j - coin[i]];
                }
                stb.AppendLine(money[amount].ToString());
            }
            Console.WriteLine(stb);
        }
    }
}
