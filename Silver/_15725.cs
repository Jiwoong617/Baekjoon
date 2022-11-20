using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Practice
{
    class _15725
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            if (s[0] == 'x')
            {
                Console.WriteLine(1);
                return;
            }
            else if (s[0] == '-' && s[1] == 'x')
            {
                Console.WriteLine(-1);
                return;
            }
            else if (!s.Contains('x'))
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                string[] ss = s.Split('x');
                Console.WriteLine(ss[0]);
            }
        }
    }
}
