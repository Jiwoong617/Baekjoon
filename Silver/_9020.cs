using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _9020
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder stb = new StringBuilder();
            bool prime;
            bool prime2;

            for(int i = 0; i<num; i++)
            {
                int n = int.Parse(Console.ReadLine());
                for(int j = n/2; j>=2 ; j--)
                {
                    prime = true;
                    prime2 = true;
                    for(int k = 2; k*k<=j; k++)
                    {
                        if(j%k == 0)
                        {
                            prime = false;
                            break;
                        }
                    }

                    if (prime)
                    {
                        for (int k = 2; k * k <= n-j; k++)
                        {
                            if ((n-j) % k == 0)
                            {
                                prime2 = false;
                                break;
                            }
                        }
                    }

                    if (prime && prime2)
                    {
                        stb.AppendLine($"{j} {n - j}");
                        break;
                    }
                }
            }
            Console.WriteLine(stb);
        }
    }
}
