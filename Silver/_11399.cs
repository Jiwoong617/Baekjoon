using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _11399
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);

            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += (arr[i] * (n - i));

            Console.WriteLine(sum);
        }
    }
}
