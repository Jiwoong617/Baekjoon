using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _15990
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            long[,] arr = new long[100001, 3];
            arr[1, 0] = 1; arr[1, 1] = 0; arr[1, 2] = 0;
            arr[2, 0] = 0; arr[2, 1] = 1; arr[2, 2] = 0;
            arr[3, 0] = 1; arr[3, 1] = 1; arr[3, 2] = 1;

            for (int i = 4; i <= 100000; i++)
            {
                arr[i, 0] = (arr[i - 1, 1] + arr[i - 1, 2]) % 1000000009;
                arr[i, 1] = (arr[i - 2, 0] + arr[i - 2, 2]) % 1000000009;
                arr[i, 2] = (arr[i - 3, 0] + arr[i - 3, 1]) % 1000000009;
            }

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                stb.AppendLine(((arr[n, 0] + arr[n, 1] + arr[n, 2])% 1000000009).ToString());
            }
            Console.WriteLine(stb);
        }
    }
}
