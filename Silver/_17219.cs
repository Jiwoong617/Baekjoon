using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _17219
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int[] n = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            for(int i = 0; i< n[0]; i++)
            {
                string[] s = sr.ReadLine().Split();
                dic.Add(s[0], s[1]);
            }

            for(int i = 0; i< n[1]; i++)
            {
                string s = sr.ReadLine();
                stb.AppendLine(dic[s]);
            }

            sw.WriteLine(stb);
            sw.Close();
            sr.Close();
        }
    }
}
