using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _11728
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int[] n = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int i = 0; int j = 0;
            while (i < n[0] && j < n[1])
                stb.Append(a[i] < b[j] ? $"{a[i++]} " : $"{b[j++]} ");
            while (i < n[0])
                stb.Append($"{a[i++]} ");
            while (j < n[1])
                stb.Append($"{b[j++]} ");
            sw.WriteLine(stb);
            sr.Close();
            sw.Close();
        }
    }
}
