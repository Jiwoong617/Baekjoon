using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _2839
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum_2 = 0;
            while(n > 0)
            {
                if (n % 5 == 0)
                {
                    sum = n / 5;
                    break;
                }

                n -= 3;
                sum_2++;
            }
            if (n >= 0)
                Console.WriteLine(sum + sum_2);
            else
                Console.WriteLine(-1);
        }
    }
}
