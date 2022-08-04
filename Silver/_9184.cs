using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _9184
    {
        static int[,,] num = new int[21,21,21];

        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            while (true)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                if (arr[0] == -1 && arr[1] == -1 && arr[2] == -1)
                    break;

                stb.AppendLine($"w({arr[0]}, {arr[1]}, {arr[2]}) = {w(arr[0],arr[1],arr[2])}");
            }
            Console.WriteLine(stb);
        }

        static int w(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return 1;
            else if (a > 20 || b > 20 || c > 20)
                return w(20, 20, 20);
            else if (a < b && b < c)
            {
                if (num[a, b, c] != 0)
                    return num[a, b, c];
                else
                    return num[a, b, c] = w(a, b, c - 1) + w(a, b - 1, c - 1) - w(a, b - 1, c);
            }
            else
            {
                if (num[a, b, c] != 0)
                    return num[a, b, c];
                else
                    return num[a,b,c] = w(a - 1, b, c) + w(a - 1, b - 1, c) + w(a - 1, b, c - 1) - w(a - 1, b - 1, c - 1);
            }
        }
    }
}
