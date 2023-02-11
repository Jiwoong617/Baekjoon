using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Silver
{
    internal class _1309
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[100001];
            arr[1] = 3; arr[2] = 7;
            for (int i = 3; i <= n; i++)
                arr[i] = (arr[i - 1] * 2 + arr[i - 2]) % 9901;
            Console.WriteLine(arr[n]);
        }
    }
}
