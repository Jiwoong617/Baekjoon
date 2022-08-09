using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _1912
    {
        static void Main_시간초과(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] num = new int[n];

            for(int i = 0; i<n; i++)
            {
                int[] temp = Enumerable.Repeat(arr[i], n-i).ToArray();

                for(int j =i+1; j<n-i; j++)
                {
                    temp[j] = temp[j-1] + arr[j];
                }
                num[i] = temp.Max();
            }
            Console.WriteLine(num.Max());
        }
    }
}
