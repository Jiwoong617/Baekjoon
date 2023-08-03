using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _6588
    {
        static void Main(string[] args)
        {
            StringBuilder stb= new StringBuilder();
            bool[] isPrime = Enumerable.Repeat(true, 1000001).ToArray();
            isPrime[0] = false; isPrime[1] = false;

            for(int i = 2; i*i<1000000;  i++)
            {
                if(isPrime[i])
                {
                    for (int j = i * i; j< 1000000; j += i)
                        isPrime[j] = false;
                }
            }

            int n = int.Parse(Console.ReadLine());
            bool canMake;
            while (n != 0)
            {
                canMake = false;

                for(int i = 3; i<n; i+=2)
                {
                    if (isPrime[i] && isPrime[n - i])
                    {
                        canMake = true;
                        stb.AppendLine($"{n} = {i} + {n - i}");
                        break;
                    }
                }

                if (!canMake)
                    stb.AppendLine("Goldbach's conjecture is wrong.");

                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(stb);
        }
    }
}
