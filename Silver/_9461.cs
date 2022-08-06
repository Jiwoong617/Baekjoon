using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _9461
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            long[] arr = new long[101];
            arr[0] = 0; arr[1] = 1; arr[2] = 1; arr[3] = 1; arr[4] = 2; arr[5] = 2;

            /*  4 = 1 + 3
                5 = 0 + 4
                6 = 1 + 5 <- 6번째 부터 규칙 적용되는거 같음.
                7 = 2 + 6
                8 = 3 + 7
                9 = 4 + 8
                10 = 5 + 9
                11 = 6 + 10 */

            for (int i = 6; i <= 100; i++)
                arr[i] = arr[i - 1] + arr[i - 5];

            for (int i = 0; i < n; i++)
                stb.AppendLine(arr[int.Parse(Console.ReadLine())].ToString());

            Console.WriteLine(stb);
        }
    }
}
