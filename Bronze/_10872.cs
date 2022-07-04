using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _10872
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = fact(num);
            Console.WriteLine(sum);
        }

        public static int fact(int num)
        {
            if (num <= 1)
                return 1;
            else
                return num * fact(num - 1);
        }
    }
}
