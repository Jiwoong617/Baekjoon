using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _9507
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            long[] arr = new long[68];
            arr[0] = arr[1] = 1; arr[2] = 2; arr[3] = 4;
            for (int i = 4; i < 68; i++)
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3] + arr[i - 4];

            while (n-- > 0)
                stb.AppendLine(arr[int.Parse(Console.ReadLine())].ToString());

            Console.WriteLine(stb);
        }
    }
}
