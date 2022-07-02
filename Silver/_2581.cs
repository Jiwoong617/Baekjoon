using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _2581
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int min = 0;
            bool prime;

            for (int i= m; i <=n; i++)
            {
                prime = true;
                if (i < 2)
                    continue;

                for(int j = 2; j*j<=i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    sum += i;
                    if (min < m)
                        min = i;
                }
            }
            if (sum != 0)
                Console.WriteLine($"{sum}\n{min}");
            else
                Console.WriteLine(-1);
        }
    }
}
