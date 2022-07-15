using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _1764
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] arr = new string[num[1]];
            int sum = 0;

            for(int i =0; i<num[0]; i++)
                dict.Add(Console.ReadLine(), 1);

            for (int i = 0; i < num[1]; i++)
                arr[i] = Console.ReadLine();

            Array.Sort(arr);

            foreach(string str in arr)
            {
                if (dict.ContainsKey(str))
                {
                    sum++;
                    stb.AppendLine(str);
                }
            }
            Console.WriteLine($"{sum}\n{stb}");
        }
    }
}
