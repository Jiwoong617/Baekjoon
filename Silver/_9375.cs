using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _9375
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i<n; i++)
            {
                int n2 = int.Parse(Console.ReadLine());
                Dictionary<string, int> dict = new Dictionary<string, int>();
                int sum = 1;

                for(int j = 0; j<n2; j++)
                {
                    string[] str = Console.ReadLine().Split();
                    if (dict.ContainsKey(str[1]))
                        dict[str[1]]++;
                    else
                        dict.Add(str[1], 1);
                }

                foreach (string s in dict.Keys)
                    sum *= dict[s] + 1;

                stb.AppendLine((sum-1).ToString());
            }
            Console.WriteLine(stb);
        }
    }
}
