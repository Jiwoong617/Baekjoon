using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon
{
    class _1157
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine().ToUpper();
            int[] alpha = Enumerable.Repeat(0, 26).ToArray(); //enmerable - linq 있어야 사용가능

            foreach (char c in str)
            {
                alpha[Convert.ToInt32(c) - 65]++;
            }

            int max = alpha.Max();
            int index = Array.IndexOf(alpha, max);
            int lindex = Array.LastIndexOf(alpha, max);

            if (index == lindex)
                Console.WriteLine(Convert.ToChar(index+65));
            else
                Console.WriteLine("?");
        }
    }
}
