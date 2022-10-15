using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1748
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int len = n.ToString().Length-1;
            long ans = 0;

            for(int i = 0; i<len; i++)
            {
                long sum = (i+1)*(int)Math.Pow(10,i)*9;
                //Console.WriteLine(sum);
                ans += sum;
            }
            long s = (n - (int)Math.Pow(10, len) + 1) * (len+1);
            ans += s;
            Console.WriteLine(ans);
        }
    }
}
