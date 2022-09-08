using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.silver
{
    class _1654
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            long[] line = new long[n[0]];
            for (int i = 0; i < n[0]; i++)
                line[i] = long.Parse(Console.ReadLine());

            long high = line.Max();
            long low = 1;
            long mid = 0;
            long sum = 0;
            while(high - low >= 0)
            {
                sum = 0;
                mid = (high + low) / 2;
                for(int i = 0; i < n[0]; i++)
                    sum += line[i] / mid;

                if (sum >= n[1])
                    low = mid+1;
                else
                    high = mid-1;

            }

            Console.WriteLine(high);
        }
        
    }
}
