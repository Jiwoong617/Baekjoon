using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _11723
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());
            HashSet<int> set = new HashSet<int>();

            for(int i = 0; i< n; i++)
            {
                string[] s = sr.ReadLine().Split();
                int num = 0;
                if(s.Length > 1)
                    num = int.Parse(s[1]);

                switch (s[0])
                {
                    case "add":
                        {
                            set.Add(num);
                            break;
                        }
                    case "remove":
                        {
                            set.Remove(num);
                            break;
                        }
                    case "check":
                        {
                            if (set.Contains(num))
                                stb.AppendLine("1");
                            else
                                stb.AppendLine("0");
                            break;
                        }
                    case "toggle":
                        {
                            if (set.Contains(num))
                                set.Remove(num);
                            else
                                set.Add(num);
                            break;
                        }
                    case "all":
                        {
                            set = Enumerable.Range(1, 20).ToHashSet();
                            break;
                        }
                    case "empty":
                        {
                            set.Clear();
                            break;
                        }
                }
            }
            sw.WriteLine(stb);
            sr.Close();
            sw.Close();
        }
    }
}
