using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1427
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int[] arr = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
                arr[i] = int.Parse(num[i].ToString());
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i = 0; i < num.Length; i++)
                Console.Write(arr[i]);
        }
    }
}
