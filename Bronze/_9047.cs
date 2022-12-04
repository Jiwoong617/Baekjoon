using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Practice
{
    class _9047
    {
        static void Main_9047(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int test = int.Parse(Console.ReadLine());

            for(int t = 0; t<test; t++)
            {
                string s = Console.ReadLine();

                int count = 0;
                while(s != "6174")
                {
                    count++;

                    string s1 = string.Concat(s.OrderByDescending(s => s));
                    string s2 = string.Concat(s.OrderBy(s => s));

                    int a = int.Parse(s1);
                    int b = int.Parse(s2);

                    s = (a - b).ToString();

                    while (s.Length < 4)
                        s = s + "0";
                }

                stb.AppendLine(count.ToString());
            }

            Console.WriteLine(stb);
        }
    }
}
