using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _3273
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);
            int x = int.Parse(Console.ReadLine());

            int min = 0;
            int max = n - 1;
            int count = 0;
            while (max > min)
            {
                if (arr[max] + arr[min] == x)
                {
                    count++;
                    min++;
                }
                else if (arr[max] + arr[min] > x)
                    max--;
                else
                    min++;
            }
            Console.WriteLine(count);
        }
    }
}
