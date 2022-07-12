using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Baekjoon.Silver
{
    class _11870
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder stb = new StringBuilder();

            int num = int.Parse(sr.ReadLine());
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int temp = 0;

            int[] arr2 = arr.OrderBy(x => x).Distinct().ToArray();
            dict.Add(arr2[0], 0);
            
            for (int i = 1; i<arr2.Length; i++)
            {
                if(arr2[i]> arr2[i - 1])
                    temp++;

                dict.Add(arr2[i], temp);
            }

            foreach (int i in arr)
                stb.Append($"{dict[i]} ");
            
            sw.WriteLine(stb);
            sr.Close();
            sw.Close();
        }
    }
}
