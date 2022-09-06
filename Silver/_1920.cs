using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.silver
{
    class _1920
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (!dict.ContainsKey(a[i]))
                    dict.Add(a[i], 1);
            }


            int m = int.Parse(Console.ReadLine());
            int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for(int i = 0; i<m; i++)
            {
                if (dict.ContainsKey(b[i]))
                    stb.AppendLine("1");
                else
                    stb.AppendLine("0");
            }

            Console.WriteLine(stb);
        }
    }
}
