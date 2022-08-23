using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _1931
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            var meeting = arr.OrderBy(x => x[1]).ThenBy(x => x[0]).ToArray();

            int count = 0;
            int time = -1;
            for(int i = 0; i<n; i++)
            {
                if(time <= meeting[i][0])
                {
                    count++;
                    time = meeting[i][1];
                }
            }

            Console.WriteLine(count);
        }
    }
}
