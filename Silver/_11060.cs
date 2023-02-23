using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Silver
{
    internal class _11060
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] jumpCount = Enumerable.Repeat(100000, n).ToArray();
            jumpCount[0] = 0;

            for(int i = 0; i< n; i++)
            {
                int jump = i + arr[i];

                while(jump != i)
                {
                    if(jump >= n)
                    {
                        jump--;
                        continue;
                    }

                    jumpCount[jump] = Math.Min(jumpCount[jump], jumpCount[i] + 1);
                    jump--;
                }
            }
            //Console.WriteLine(string.Join(" ", jumpCount));
            Console.WriteLine(jumpCount[n - 1] == 100000 ? "-1" : jumpCount[n - 1].ToString());
        }
    }
}
