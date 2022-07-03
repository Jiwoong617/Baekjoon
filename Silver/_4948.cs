using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _4948
    {
        static void Main(string[] args)
        {
            bool prime;
            int sum = 0;
            StringBuilder stb = new StringBuilder();
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                sum = 0;
                if (n == 0)
                    break;

                for (int i = n+1; i <= 2*n; i++){
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
                        sum++;
                }
                stb.AppendLine(sum.ToString());
            }
            Console.WriteLine(stb);
        }
    }
}
