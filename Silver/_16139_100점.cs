using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _16139
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            string s = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            int[,] sum = new int[s.Length+1,26];
            for(int i = 1; i<=s.Length; i++)
            {
                int idx = s[i-1] - 'a';
                for(int j = 0; j<26; j++)
                {
                    if (j == idx)
                        sum[i, j] = sum[i - 1, j] + 1;
                    else
                        sum[i, j] = sum[i - 1, j];
                }
            }

            for(int i = 0; i<n; i++)
            {
                string[] a = Console.ReadLine().Split();
                char c = Convert.ToChar(a[0]);
                int num1 = Convert.ToInt32(a[1]);
                int num2 = Convert.ToInt32(a[2]);

                stb.AppendLine((sum[num2+1,c-'a']-sum[num1, c-'a']).ToString());
            }
            Console.WriteLine(stb);
        }
    }
}
