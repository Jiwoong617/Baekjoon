using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _11478
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for(int i = 0; i<s.Length; i++)
            {
                string a = "";
                for(int j = i; j<s.Length; j++)
                {
                    a += s[j];
                    if (!dict.ContainsKey(a))
                        dict.Add(a, 1);
                }
            }

            Console.WriteLine(dict.Count);
        }
    }
}
