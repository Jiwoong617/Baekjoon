using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Baekjoon.Silver
{
    class _1269
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sr.ReadLine();
            int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            int anum = a.Except(b).Count();
            int bnum = b.Except(a).Count();

            Console.WriteLine(anum + bnum);
        }
    }
}
