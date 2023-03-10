using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _15989
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            int[,] arr = new int[10001, 3];
            arr[1, 0] = arr[2, 0] = 1;
            for(int i = 2; i<10001; i++)
            {
                arr[i, 0] = 1;
                arr[i, 1] = 1 + arr[i-2,1];
                if (i >= 3)
                    arr[i, 2] = 1 + arr[i - 3, 1] + arr[i - 3, 2];
            }

            while(t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                stb.AppendLine((1 + arr[n, 1] + arr[n, 2]).ToString());
            }
            Console.WriteLine(stb);
        }
    }
}
