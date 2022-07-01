using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1978
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;
            bool prime = false;

            foreach(int i in num)
            {
                prime = true;
                if (i < 2)
                    continue;

                for(int j = 2; j*j<=i; j++)
                {
                    if (i % j == 0)
                        prime = false;
                }
                if (prime)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
