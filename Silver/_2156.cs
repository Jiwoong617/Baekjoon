using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.silver
{
    class _2156
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] score = new int[n+1];
            int[] arr = new int[n + 1];
            for (int i = 1; i <= n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            score[0] = arr[0];
            score[1] = arr[1];
            if (n > 1)
                score[2] = arr[2] + arr[1];

            //0x00, x0x0, (xx0x or x00x)
            for (int i = 3; i <= n; i++)
                score[i] = Math.Max(Math.Max(score[i - 3] + arr[i - 1] + arr[i], score[i - 2] + arr[i]), score[i-1]);

            Console.WriteLine(score[n]);
        }
    }
}
