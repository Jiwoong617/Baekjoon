using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Baekjoon.Gold
{
    class _2981
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(sr.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
                a[i] = int.Parse(sr.ReadLine());

            for (int i = 2; i<=a.Max(); i++)
            {
                int temp = a[0] % i;
                foreach(int j in a)
                {
                    if(temp != j % i)
                    {
                        temp = -1;
                        break;
                    }
                }

                if (temp != -1)
                    stb.Append($"{i} ");
            }

            sw.WriteLine(stb);
            sw.Close();
            sr.Close();
        }
    }
}
