using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _2231
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int ans = 0;

            for(int i = 1; i<= num; i++)
            {
                ans = 0;
                string n = i.ToString();
                for (int j = 0; j < i.ToString().Length; j++)
                    ans += int.Parse(n[j].ToString());

                if (i + ans == num)
                {
                    ans = i;
                    break;
                }
                else
                    ans = 0;
            }
            Console.WriteLine(ans);
        }
    }
}
