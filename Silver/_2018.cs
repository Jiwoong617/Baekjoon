using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Practice
{
    class _2018
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            int min = 1;
            int max = 2;
            while (max < n)
            {
                int sum = (min + max) * (max - min + 1) / 2;
                if (sum > n)
                    min++;
                else if (sum < n)
                    max++;
                else
                {
                    count++;
                    min++;
                }
            }

            Console.WriteLine(count+1);
        }
    }
}
