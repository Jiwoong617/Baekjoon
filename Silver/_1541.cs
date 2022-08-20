using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1541
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split('-');
            int[] n = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                string[] str = s[i].Split('+');
                for (int j = 0; j < str.Length; j++)
                    n[i] += int.Parse(str[j]);
            }

            int sum = n[0];
            for (int i = 1; i < n.Length; i++)
                sum -= n[i];

            Console.WriteLine(sum);
        }
    }
}
