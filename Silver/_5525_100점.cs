using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _5525
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int len = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int ans = 0;

            int i = 0;
            int count = 0;
            while(i < len - 2)
            {
                if (s[i..(i+3)] == "IOI")
                {
                    i += 2;
                    count++;
                    if (count == n)
                    {
                        ans++;
                        count--;
                    }
                }
                else
                {
                    i++;
                    count = 0;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
