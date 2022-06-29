using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1316
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i<n; i++)
            {
                string str = Console.ReadLine();
                bool grp = true;
                for(int j = 0; j<str.Length; j++)
                {
                    int a = str.IndexOf(str[j]);
                    int b = str.LastIndexOf(str[j]);
                    while (a < b)
                    {
                        if(str[a] != str[a + 1])
                        {
                            grp = false;
                            break;
                        }
                        a++;
                    }
                    if (!grp)
                        break;
                }
                if (grp)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}