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
            char temp = 'A';

            int[] sum = new int[s.Length+1];
            for(int i = 0; i<n; i++)
            {
                string[] a = Console.ReadLine().Split();
                char c = Convert.ToChar(a[0]);
                int num1 = Convert.ToInt32(a[1]);
                int num2 = Convert.ToInt32(a[2]);

                if (temp != c)
                {
                    temp = c;
                    sum = new int[s.Length + 1];
                    for (int j = 1; j<=s.Length; j++)
                    {
                        if (c == s[j-1])
                            sum[j] += sum[j - 1] + 1;
                        else
                            sum[j] = sum[j - 1];
                    }
                }

                stb.AppendLine((sum[num2+1] - sum[num1]).ToString());
            }
            Console.WriteLine(stb);
        }
    }
}
