using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _2750
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Array.Sort(arr);
            for (int i = 0; i < num; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
