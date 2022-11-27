using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Baekjoon.Practice
{
    class _4659
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder stb = new StringBuilder();

            char[] c = { 'a', 'e', 'i', 'o', 'u' };
 
            string s = "";
            while(true)
            {
                s = sr.ReadLine();
                if (s == "end")
                    break;

                bool flag = true;
                //조건 1
                if (!s.Contains('a') && !s.Contains('e') && !s.Contains('i') && !s.Contains('o') && !s.Contains('u'))
                {
                    flag = false;
                    stb.AppendLine($"<{s}> is not acceptable.");
                    continue;
                }

                //조건 2
                for(int i = 0; i < s.Length-2; i++)
                {
                    string ss = s.Substring(i, 3);
                    bool f1 = true;
                    bool f2 = true;
                    bool f3 = true;

                    if (ss[0] == 'a' || ss[0] == 'e' || ss[0] == 'i' || ss[0] == 'o' || ss[0] == 'u')
                        f1 = true;
                    else f1 = false;

                    if (ss[1] == 'a' || ss[1] == 'e' || ss[1] == 'i' || ss[1] == 'o' || ss[1] == 'u')
                        f2 = true;
                    else f2 = false;

                    if (ss[2] == 'a' || ss[2] == 'e' || ss[2] == 'i' || ss[2] == 'o' || ss[2] == 'u')
                        f3 = true;
                    else f3 = false;

                    if ((f1 && f2 && f3) || (!f1 && !f2 && !f3))
                    {
                        flag = false;
                        stb.AppendLine($"<{s}> is not acceptable.");
                        break;
                    }
                }

                //조건 3
                for(int i = 0; i<s.Length-1; i++)
                {
                    if ((s[i] == 'e' && s[i + 1] == 'e') || (s[i] == 'o' && s[i + 1] == 'o'))
                        continue;
                    else if (s[i] == s[i + 1])
                    {
                        flag = false;
                        stb.AppendLine($"<{s}> is not acceptable.");
                        break;
                    }
                }

                if(flag)
                    stb.AppendLine($"<{s}> is acceptable.");
            }

            sw.WriteLine(stb);
            sr.Close();
            sw.Close();
        }
    }
}
