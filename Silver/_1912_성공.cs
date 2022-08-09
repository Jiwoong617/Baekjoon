using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _1912
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] temp = new int[n];
            temp[0] = arr[0];

            for(int i = 1; i<n; i++)
                temp[i] = Math.Max(temp[i - 1] + arr[i], arr[i]);

            Console.WriteLine(temp.Max());
        }
    }
}
