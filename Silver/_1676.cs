using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1676
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int zero = 0;

            for (int i = int.Parse(a); i > 0; i--)
            {
                if (i % 5 == 0)
                    zero++;
                if (i % 25 == 0)
                    zero++;
                if (i % 125 == 0)
                    zero++;
            }

            Console.WriteLine(zero);
        }
    }
}
