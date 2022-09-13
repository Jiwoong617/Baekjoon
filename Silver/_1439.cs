using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.silver
{
    class _1439
    {
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string[] s0 = s.Split("0", StringSplitOptions.RemoveEmptyEntries);
            string[] s1 = s.Split("1", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(Math.Min(s0.Length, s1.Length));
        }
    }
}
