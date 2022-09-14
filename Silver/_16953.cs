using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.silver
{
    class _16953
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;

            while (n[1] > n[0])
            {
                if (n[1] % 2 == 0)
                {
                    count++;
                    n[1] /= 2;
                }
                else if (n[1] % 10 == 1)
                {
                    count++;
                    n[1] /= 10;
                }
                else if (n[1] % 2 != 0 && n[1] % 10 != 1)
                    break;
            }

            if (n[1] == n[0])
                Console.WriteLine(count + 1);
            else
                Console.WriteLine(-1);
        }
    }
}
