using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.silver
{
    class _1049
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] set = new int[n[1]];
            int[] one = new int[n[1]];

            for(int i = 0; i< n[1]; i++)
            {
                int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                set[i] = num[0];
                one[i] = num[1];
            }

            int setmin = set.Min();
            int onemin = one.Min();
            if (setmin < onemin*6)
                Console.WriteLine(Math.Min((n[0] / 6) * setmin + (n[0] % 6) * onemin, (n[0]/6+1)*setmin));
            else
                Console.WriteLine(n[0] * onemin);
        }
    }
}
