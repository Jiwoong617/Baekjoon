using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _2193
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] arr = new long[91];
            arr[1] = 1; arr[2] = 1;
            for (int i = 3; i <= n; i++)
                arr[i] = arr[i - 1] + arr[i - 2];
            Console.WriteLine(arr[n]);
        }
    }
}
