using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _1193
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int line = 0;
            int sum = 0;
            while (sum < a)
            {
                line++;
                sum += line;
            }
            int temp = a - sum + line;
            // 줄이 홀수면 분모 증가, 짝수면 분자 증가
            if (line % 2 == 1)
                Console.WriteLine($"{line + 1 - temp}/{temp}");
            else
                Console.WriteLine($"{temp}/{line + 1 - temp}");
        }
    }
}