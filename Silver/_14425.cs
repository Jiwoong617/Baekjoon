using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _14425
    {
        static void Main(string[] args)
        {
            int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string[] str = new string[num[0] + num[1]];
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
                str[i] = Console.ReadLine();

            foreach (string s in str[0..num[0]])
                dict.Add(s, 1);

            foreach (string s in str[num[0]..])
            {
                if (dict.ContainsKey(s))
                    sum++;
            }
            Console.WriteLine(sum);
        }
    }
}
