using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1904
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[1000001];
            arr[0] = 0; arr[1] = 1; arr[2] = 2;

            //개수가 피보나치 수열처럼 증가함 -> 1 2 3 5 8 13 21 34 ...
            for (int i = 3; i <= n; i++)
                arr[i] = (arr[i - 1] + arr[i - 2]) % 15746;

            Console.WriteLine(arr[n]);
        }
    }
}
