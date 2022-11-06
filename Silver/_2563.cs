using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _2563
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[100, 100];
            int count = 0;
            for(int i = 0; i< n; i++)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int x = a[0]; x<a[0]+10; x++)
                {
                    for (int y = a[1]; y < a[1] + 10; y++)
                    {
                        if (arr[x, y] == 1)
                            continue;

                        arr[x, y] = 1;
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
