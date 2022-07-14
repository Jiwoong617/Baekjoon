using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Baekjoon.Silver
{
    class _1620
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int[] num = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string[] arr = new string[num[1]];
            string[] str = new string[100001];

            for (int i = 0; i < num[0]; i++)
            {
                string poket = sr.ReadLine();
                dict.Add(poket, (i + 1).ToString());
                str[i+1] = poket;
            }

            for (int i = 0; i < num[1]; i++)
                arr[i] = sr.ReadLine();

            foreach(string s in arr)
            {
                bool n = int.TryParse(s, out _);

                if (!n)
                    stb.AppendLine(dict[s]);
                else
                {
                    int a = int.Parse(s);
                    stb.AppendLine(str[a]);
                }
            }

            sw.WriteLine(stb);
            sr.Close();
            sw.Close();
        }
    }
}
