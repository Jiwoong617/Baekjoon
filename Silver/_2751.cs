using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _2751
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder stb = new StringBuilder();
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Array.Sort(arr);
            for (int i = 0; i < num; i++)
                stb.AppendLine($"{arr[i]}");

            Console.WriteLine(stb);
        }
    }
}
