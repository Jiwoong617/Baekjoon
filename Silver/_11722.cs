using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _11722
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] count = Enumerable.Repeat(1, n).ToArray();

            for(int i =1; i<n; i++)
            {
                for(int j =0; j<i; j++)
                {
                    if (arr[i] < arr[j])
                        count[i] = Math.Max(count[i], count[j] + 1);
                }
            }
            Console.WriteLine(count.Max());
        }
    }
}
