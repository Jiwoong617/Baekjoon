using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Baekjoon.Gold
{
    class _5430
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(sr.ReadLine());
            char[] delimeter = { '[', ']', ',' };

            for (int i = 0; i < n; i++)
            {
                //입력
                string func = sr.ReadLine();
                int num = int.Parse(sr.ReadLine());
                string s = sr.ReadLine();
                string[] s2 = s.Substring(1, s.Length - 2).Split(",", StringSplitOptions.RemoveEmptyEntries);
                List<int> deque = new List<int>();
                for (int j = 0; j < s2.Length; j++)
                    deque.Add(int.Parse(s2[j]));
                //List<int> deque = new List<int>(Array.ConvertAll(sr.ReadLine().Split(delimeter, StringSplitOptions.RemoveEmptyEntries), int.Parse));
                //밑에거가 더느림
                //지금까지 시간초과로 실패 했었던건 list<String>이 list<int>보다 매우 느려서

                //함수 적용
                bool iserror = false;
                bool isreverse = false;
                int dcount = func.Count(x => x == 'D');
                if (dcount > deque.Count)
                {
                    if (func.Contains("D"))
                    {
                        iserror = true;
                        stb.AppendLine("error");
                        continue;
                    }
                }

                foreach (char c in func)
                {
                    if (c == 'R')
                        isreverse = !isreverse;
                    else if (c == 'D')
                    {
                        if (isreverse)
                        {
                            deque.RemoveAt(deque.Count - 1);
                        }
                        else
                        {
                            deque.RemoveAt(0);
                        }
                    }
                }

                if (iserror)
                    stb.AppendLine("error");
                else
                {
                    if (isreverse)
                        deque.Reverse();
                    stb.Append("[");
                    stb.Append(string.Join(",", deque));
                    stb.AppendLine("]");
                }

            }
            sw.WriteLine(stb);
            sr.Close();
            sw.Close();
        }
    }
}
