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
            int n = int.Parse(Console.ReadLine());
            while(n != 0)
            {
                bool prime = true;
                bool prime2 = true;
                int a = 0; int b = 0;

                for(int i = n/2; i>=2; i--)
                {
                    prime = true;
                    prime2 = true;

                    for (int j = 2; j * j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                            break;
                        }
                    }

                    if (prime)
                    {
                        for (int j = 2; j * j <= n - i; j++)
                        {
                            if ((n - i) % j == 0)
                            {
                                prime2 = false;
                                break;
                            }
                        }
                    }

                    if (prime && prime2){ a = i; b = n - i; }
                }

                if (a != 0 && b != 0)
                    stb.AppendLine($"{n} = {a} + {b}");
                else
                    stb.AppendLine("Goldbach's conjecture is wrong.");

                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(stb);
        }
    }
}
