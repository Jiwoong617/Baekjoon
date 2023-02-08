using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace BaekJoon.Silver
{
    internal class _11057
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] count = new int[n+1, 10];
            for(int i = 0; i< 10; i++)
                count[1,i] = 1;

            for(int i = 2; i<= n; i++)
            {
                for(int j = 0; j< 10; j++)
                {
                    int sum = 0;
                    for(int k = j; k<10; k++)
                        sum += (count[i - 1, k] % 10007);

                    count[i, j] = sum % 10007;
                }
            }

            int ans = 0;
            for (int i = 0; i < 10; i++)
                ans += (count[n, i] % 10007);

            Console.WriteLine(ans%10007);
        }
    }
}
