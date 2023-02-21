using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Silver
{
    internal class _14916
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            while(n > 0)
            {
                if(n%5 == 0)
                {
                    count += (n / 5);
                    n %= 5;
                    break;
                }

                n -= 2;
                count++;
            }
            if (count != 0 && n == 0)
                Console.WriteLine(count);
            else
                Console.WriteLine(-1);
        }
    }
}
