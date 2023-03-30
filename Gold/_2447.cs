using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _2447
    {
         static StringBuilder stb = new StringBuilder();

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                    Star(i, j, n);
                stb.AppendLine();
            }
            Console.WriteLine(stb);
        }

        static void Star(int i, int j , int n)
        {
            if ((i / n) % 3 == 1 && (j / n) % 3 == 1)
                stb.Append(' ');
            else if (n == 1)
                stb.Append('*');
            else
                Star(i, j, n/3);
        }
    }
}
