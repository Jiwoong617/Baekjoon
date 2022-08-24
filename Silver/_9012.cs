using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _9012
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i<n; i++)
            {
                int sum = 0;
                string s = Console.ReadLine();
                bool isVPS = true;

                foreach (char c in s)
                {
                    if (c == '(')
                        sum++;
                    else
                        sum--;

                    if (sum < 0)
                    {
                        isVPS = false;
                        break;
                    }
                }

                if (sum > 0)
                    isVPS = false;

                if (isVPS)
                    stb.AppendLine("YES");
                else
                    stb.AppendLine("NO");
            }
            Console.WriteLine(stb);
        }
    }
}
