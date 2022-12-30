using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _11726
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[1001];
            arr[0] = 0; arr[1] = 1; arr[2] = 2;

            for (int i = 3; i < 1001; i++)
                arr[i] = (arr[i - 1] + arr[i - 2])%10007;

            Console.WriteLine(arr[n]);
        }
    }
}
