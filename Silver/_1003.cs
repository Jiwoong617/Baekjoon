using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _1003
    {
        static void Main(String[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[41, 2];
            arr[0, 0] = 1; arr[0, 1] = 0;
            arr[1, 0] = 0; arr[1, 1] = 1;
            arr[2, 0] = 1; arr[2, 1] = 1;

            for(int i = 3; i<41; i++)
            {
                arr[i, 0] = arr[i - 1, 1];
                arr[i, 1] = arr[i - 1, 1] + arr[i - 2, 1];
            }

            for(int i = 0; i< n; i++)
            {
                int t = int.Parse(Console.ReadLine());
                stb.AppendLine($"{arr[t, 0]} {arr[t, 1]}");
            }

            Console.WriteLine(stb);
        }
    }
}
