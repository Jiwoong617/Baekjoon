using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Baekjoon.Gold
{
    class _2981
    {
        static int gcd(int a, int b) => b == 0 ? a : gcd(b, a % b);

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder stb = new StringBuilder();

            int n = int.Parse(sr.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(sr.ReadLine());

            Array.Sort(a);
            int yaksoo = a[1] - a[0];

            for(int i = 2; i<a.Length; i++)
                yaksoo = gcd(yaksoo, a[i] - a[i - 1]);

            for (int i = 2; i <= yaksoo; i++)
                if (yaksoo % i == 0)
                    stb.Append($"{i} ");

            sw.WriteLine(stb);
            sw.Close();
            sr.Close();
        }
    }
}
