using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.Gold
{
    internal class _17352
    {
        static int[] island;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            island = Enumerable.Range(0, n).ToArray();

            for(int i = 0; i < n-2; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                MakeUnion(arr[0] - 1, arr[1] - 1);
            }
            for (int i = 0; i < n; i++)
                if (island[i] == i)
                    Console.Write(i + 1 + " ");
        }

        static int FindP(int n)
        {
            if (n == island[n])
                return n;

            return island[n] = FindP(island[n]);
        }

        static void MakeUnion(int a, int b)
        {
            a = FindP(a);
            b = FindP(b);

            if (a > b) island[a] = b;
            else island[b] = a;
        }
    }
}
