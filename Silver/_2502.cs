using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _2502
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //0 - day, 1 - ricecake
            int[] a = new int[31]; a[3] = 1; a[4] = 1;
            int[] b = new int[31]; b[3] = 1; b[4] = 2;
            for(int i = 5; i<31; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
                b[i] = b[i - 1] + b[i - 2];
            }
            //Console.WriteLine(string.Join(" ",a));
            //Console.WriteLine(string.Join(" ",b));

            int first = a[n[0]];
            int second = b[n[0]];
            for(int i = 1; i <100000; i++)
            {
                if ((n[1] - first * i) % second == 0)
                {
                    Console.WriteLine($"{i}\n{(n[1] - first * i) / second}");
                    break;
                }
            }
        }
    }
}
