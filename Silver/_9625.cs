using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Silver
{
    internal class _9625
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n + 1, 2];
            arr[0, 0] = 1; arr[0, 1] = 0;
            arr[1, 0] = 0; arr[1, 1] = 1;
            for (int i = 2; i <= n; i++)
            {
                arr[i, 0] = arr[i - 1, 0] + arr[i - 2, 0];
                arr[i, 1] = arr[i - 1, 1] + arr[i - 2, 1];
            }
            Console.WriteLine(arr[n, 0] + " " + arr[n, 1]);
        }
    }
}
