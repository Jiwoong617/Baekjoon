using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon
{
    class _1152
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            if (a[0] == "" && a[a.Length-1] == "")
                Console.WriteLine(a.Length - 2);
            else if (a[0] == "" || a[a.Length - 1] == "")
                Console.WriteLine(a.Length-1);
            else
                Console.WriteLine(a.Length);
        }
    }
}
