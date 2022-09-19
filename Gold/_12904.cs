using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Gold
{
    class _12904
    {
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string str = Console.ReadLine();
            int n = str.Length - s.Length;

            for(int i = 0; i< n; i++)
            {
                if (str[str.Length - 1] == 'A')
                    str = str.Substring(0, str.Length - 1);
                else if (str[str.Length-1] == 'B')
                {
                    char[] c = str.Substring(0, str.Length - 1).ToCharArray();
                    Array.Reverse(c);
                    str = String.Join("", c);
                }
            }

            if (str == s)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}
