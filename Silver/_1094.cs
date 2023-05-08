using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.silver
{
    internal class _1094
    {
        static void Main(string[] args)
        {
            string s = Convert.ToString(int.Parse(Console.ReadLine()), 2);
            Console.WriteLine(s.Count(x => x=='1'));
        }
    }
}
