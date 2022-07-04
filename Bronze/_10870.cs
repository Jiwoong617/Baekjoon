using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _10870
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(pibo(num));
        }

        public static int pibo(int num)
        {
            if (num == 0)
                return 0;
            else if (num == 1)
                return 1;
            else
                return pibo(num - 1) + pibo(num - 2);
        }
    }
}
