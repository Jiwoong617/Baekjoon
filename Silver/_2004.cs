using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _2004
    {
        static void Main(string[] args)
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int fivecount = 0;
            int twocount = 0;

            //5승
            int temp = a[0];
            while(temp > 0)
            {
                fivecount += temp / 5;
                temp /= 5;
            }
            
            temp = a[1];
            while(temp > 0)
            {
                fivecount -= temp / 5;
                temp /= 5;
            }
            
            temp = a[0]-a[1];
            while(temp > 0)
            {
                fivecount -= temp / 5;
                temp /= 5;
            }
            
            //2승
            temp = a[0];
            while(temp > 0)
            {
                twocount += temp / 2;
                temp /= 2;
            }
            
            temp = a[1];
            while(temp > 0)
            {
                twocount -= temp / 2;
                temp /= 2;
            }
            
            temp = a[0] - a[1];
            while(temp > 0)
            {
                twocount -= temp / 2;
                temp /= 2;
            }

            Console.WriteLine(Math.Min(fivecount, twocount));
        }
    }
}
