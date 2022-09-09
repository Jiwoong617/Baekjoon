using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _2217
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] rope = new int[n];
            for (int i = 0; i < n; i++)
                rope[i] = int.Parse(Console.ReadLine());

            int max = 0;
            Array.Sort(rope);
            Array.Reverse(rope);
            for(int i = 0; i<n; i++)
            {
                int sum = rope[i] * (i + 1);
                if (sum > max)
                    max = sum;
            }
            Console.WriteLine(max);
        }
    }
}
