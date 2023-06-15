using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _20529
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split();
                if(n > 32) //비둘기 집 정리 : 16 + 16 + n -> 같은 것 3번
                {
                    stb.AppendLine("0");
                    continue;
                }

                int min = 24;
                for(int i = 0; i<n-2; i++)
                {   
                    for(int j = i+1; j<n-1; j++)
                    {
                        for(int k = j+1; k< n; k++)
                        {
                            int sum = Cal(s[i], s[j]) + Cal(s[i],s[k]) + Cal(s[j],s[k]);
                            min = Math.Min(min, sum);
                        }
                    }
                }
                stb.AppendLine(min.ToString());
            }
            Console.WriteLine(stb);
        }

        static int Cal(string a, string b)
        {
            int sum = 0;
            for(int i = 0; i<4; i++)
                if (a[i] != b[i])
                    sum++;

            return sum;
        }
    }
}
