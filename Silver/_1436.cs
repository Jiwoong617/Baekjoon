using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1436
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int apo = 666;
            int n = 0;
            
            while (true)
            {
                if (apo.ToString().Contains("666"))
                    n++;

                if (n == num)
                    break;

                apo++;
            }
            Console.WriteLine(apo);
        }
    }
}
