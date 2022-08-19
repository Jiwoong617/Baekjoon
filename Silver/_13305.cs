using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _13305
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] dis = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] oil = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            ulong sum = 0;
            long min = oil[0];
            for(int i = 0; i<dis.Length; i++)
            {
                if (oil[i] < min)
                    min = oil[i];

                sum = sum + (ulong)(min * dis[i]);
            }

            Console.WriteLine(sum);
        }
    }
}
