using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _11653
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder stb = new StringBuilder();
            int n = num;

            if (num == 2 || num == 3)
                stb.AppendLine($"{num}");
            for(int i = 2; i * i <= num;)
            {
                if (n % i == 0)
                {
                    n /= i;
                    stb.AppendLine(i.ToString());
                }
                else
                    i++;
            }
            if(n == 1 || num ==2 || num == 3)
                Console.WriteLine(stb);
            else
            {
                Console.Write(stb);
                Console.WriteLine(n);
            }
        }
    }
}
