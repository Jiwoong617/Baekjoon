using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1929
    {
        static void Main(string[] args)
        {
            int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            StringBuilder stb = new StringBuilder();
            bool prime;

            for (int i = num[0]; i <= num[1]; i++)
            {
                prime = true;
                if (i < 2)
                    continue;

                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                    stb.AppendLine($"{i}");
            }
            Console.WriteLine(stb);
        }
    }
}
