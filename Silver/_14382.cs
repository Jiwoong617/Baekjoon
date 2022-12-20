using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _14382
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();

            int t = int.Parse(Console.ReadLine());
            for(int test = 1; test <= t; test++)
            {
                bool[] arr = new bool[10];
                int n = int.Parse(Console.ReadLine());

                if(n == 0)
                {
                    stb.AppendLine($"Case #{test}: INSOMNIA");
                    continue;
                }

                int a = 1;
                while (true)
                {
                    int num = a * n;
                    while(num > 0)
                    {
                        arr[num % 10] = true;
                        num /= 10;
                    }

                    if (arr.All(x => x == true))
                    {
                        stb.AppendLine($"Case #{test}: {a * n}");
                        break;
                    }
                    else a++;
                }
            }
            Console.WriteLine(stb);
        }
    }
}
