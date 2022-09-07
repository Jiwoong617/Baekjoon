using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.silver
{
    class _2805
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int total = n[1];
            int[] tree = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int high = tree.Max();
            int low = 0;
            int mid = 0;
            long sum= 0;

            //이분 탐색
            while (high-low > 1)
            {
                sum = 0;
                mid = (high + low)/2;
                for(int i =0; i < n[0]; i++)
                {
                    if (tree[i] > mid)
                        sum += tree[i] - mid;
                }
                if (sum >= total)
                    low = mid;
                else
                    high = mid;
            }

            Console.WriteLine(low);
        }
    }
}
