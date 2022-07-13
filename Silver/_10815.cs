using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Baekjoon.Silver
{
    class _10815
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder stb = new StringBuilder();

            sr.ReadLine();
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            sr.ReadLine();
            int[] arr2 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                dict.Add(i, 1);
            }

            foreach (int i in arr2)
            {
                if (dict.ContainsKey(i))
                    stb.Append("1 ");
                else
                    stb.Append("0 ");
            }

            sw.WriteLine(stb);
            sr.Close();
            sw.Close();
        }
    }
}
