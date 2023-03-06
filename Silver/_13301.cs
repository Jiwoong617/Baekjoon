using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.silver
{
    internal class _13301
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(4);
                return;
            }
            ulong[] arr = new ulong[n + 1];
            arr[1] = 1; arr[2] = 1;
            for (int i = 3; i <= n; i++)
                arr[i] = arr[i - 1] + arr[i - 2];

            Console.WriteLine((arr[n] + 2 * arr[n - 1] + arr[n - 2]) * 2);
        }
    }
}
