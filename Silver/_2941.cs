using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _2941
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] cro = {"c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z="};

            for(int i=0; i<cro.Length; i++)
                str = str.Replace(cro[i], "_");

            Console.WriteLine(str.Length);
        }
    }
}