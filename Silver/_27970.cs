using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Baekjoon.silver
{
    internal class _27970
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = s.Replace('O', '1').Replace('X', '0');
            BigInteger ans = 0;
            for(int i = s.Length-1; i>= 0; i--)
            {
                ans <<= 1;
                ans += s[i] == '1' ? 1 : 0;
            }
            Console.WriteLine(ans % 1000000007);
        }
    }
}
