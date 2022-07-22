using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Bronze
{
    class _2609
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = arr.Max();
            int b = arr.Min();

            //유클리드 호제법
            while(true)
            {
                int r = a % b;
                a = b;
                b = r;

                if(b == 0)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(arr[0] * arr[1] / a);
                    break;
                }
            }
        }
    }
}
