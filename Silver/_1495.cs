using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Silver
{
    internal class _1495
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);//n, s, m
            int[] vol = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            bool[,] sound = new bool[n[0], n[2]+1];
            if (n[1] + vol[0] <= n[2])
                sound[0, n[1] + vol[0]] = true;
            if (n[1] - vol[0] >= 0)
                sound[0, n[1] - vol[0]] = true;

            for(int i = 1; i < n[0]; i++)
            {
                for(int j = 0; j<=n[2]; j++)
                {
                    if (sound[i-1, j])
                    {
                        if (j + vol[i] <= n[2])
                            sound[i, j + vol[i]] = true;
                        if (j - vol[i] >= 0)
                            sound[i, j - vol[i]] = true;
                    }
                }
            }

            int flag = 1001;
            for(int i = n[2]; i>=0; i--)
                if (sound[n[0]-1, i])
                {
                    flag = i;
                    break;
                }

            Console.WriteLine(flag == 1001 ? "-1" : flag);
        }
    }
}
