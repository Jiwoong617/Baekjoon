using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Silver
{
    internal class _11656
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = new string[s.Length];
            for (int i = 0; i < s.Length; i++)
                arr[i] = s[i..s.Length];
            Array.Sort(arr);
            Console.WriteLine(string.Join("\n", arr));
        }
    }
}
