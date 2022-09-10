using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _10610
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            string n = Console.ReadLine();
            int sum = 0;
            int[] num = new int[n.Length];

            for (int i = 0; i < n.Length; i++)
            {
                sum += int.Parse(n[i].ToString());
                num[i] = int.Parse(n[i].ToString());
            }

            if (n.Contains("0") && sum % 3 == 0)
            {
                Array.Sort(num);
                for (int i = n.Length - 1; i >= 0; i--)
                    stb.Append($"{num[i]}");
            }
            else
                stb.AppendLine("-1");

            Console.WriteLine(stb);
        }
    }
}
