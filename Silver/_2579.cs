using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _2579
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] score = new int[n+1];
            int[] arr = new int[n+1];
            for (int i = 1; i <= n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            score[0] = arr[0];
            score[1] = arr[1];
            if(n>=2)
                score[2] = arr[2] + arr[1];
            for (int i = 3; i <= n; i++)
                score[i] = Math.Max(score[i - 2] + arr[i], score[i - 3] + arr[i-1] + arr[i]);

            Console.WriteLine(score[n]);
        }
    }
}
