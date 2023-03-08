using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.silver
{
    internal class _10164
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); //n m k
            long[,] arr = new long[n[0] + 1, n[1] + 1];
            arr[0, 0] = 1; arr[1, 1] = 1;


            for(int i = 1; i <= n[0]; i++)
            {
                for(int j = 1; j <= n[1]; j++)
                    arr[i, j] += arr[i - 1, j] + arr[i, j - 1];
            }

            if (n[2] == 0)
            {
                Console.WriteLine(arr[n[0], n[1]]);
                return;
            }

            int lp = n[2] / n[1];
            int rp = n[2] % n[1] == 0 ? n[1] : n[2] % n[1];
            //Console.WriteLine(lp +" " +rp);
            long left, right;
            if (n[2] % n[1] == 0)
            {
                left = arr[lp, rp];
                right = 1;
            }
            else
            {
                left = arr[lp + 1, rp];
                right = arr[n[0] - lp, n[1] - rp+1];
            }

            Console.WriteLine(left * right);
        }
    }
}
