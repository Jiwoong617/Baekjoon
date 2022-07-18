using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _4153
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();

            while (true)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (a[0] == 0 && a[1] == 0 && a[2] == 0)
                    break;

                if ((a[0] * a[0] + a[1] * a[1] == a[2] * a[2]) || (a[0] * a[0] + a[2] * a[2] == a[1] * a[1]) || (a[2] * a[2] + a[1] * a[1] == a[0] * a[0]))
                    stb.AppendLine("right");
                else
                    stb.AppendLine("wrong");
            }
            Console.WriteLine(stb);
        }
    }
}
