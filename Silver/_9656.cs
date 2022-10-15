using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _9656
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //홀수면 창영이 이김
            if (n % 2 == 1)
                Console.WriteLine("CY");
            else
                Console.WriteLine("SK");
        }
    }
}
