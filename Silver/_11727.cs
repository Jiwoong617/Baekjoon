using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _11727
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[1000];

            //이전거 + 2*1 하나
            //이이전거에 2*2 하나
            //이이전거에 1*2 2개 붙은거 하나
            arr[0] = 1; arr[1] = 3;
            for (int i = 2; i < 1000; i++)
                arr[i] = (arr[i - 1] + 2 * arr[i - 2]) % 10007;

            Console.WriteLine(arr[n - 1]);
        }
    }
}
