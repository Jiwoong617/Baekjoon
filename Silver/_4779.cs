using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _4779
    {
        static int n;
        static char[] c;
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder stb = new StringBuilder();
            while (!sr.EndOfStream)
            {
                n = int.Parse(sr.ReadLine());
                c = Enumerable.Repeat('-', (int)Math.Pow(3,n)).ToArray();
                Cantor(0, (int)Math.Pow(3, n));
                //Console.WriteLine(string.Join("", c));
                stb.AppendLine(string.Join("",c));
            }
            Console.WriteLine(stb);
        }

        static void Cantor(int start, int size)
        {
            if (size == 1)
                return;

            int s = size / 3;
            for (int i = start+s; i < start + s*2; i++)
                c[i] = ' ';

            Cantor(start, s);
            Cantor(start + s *2, s);
        }
    }
}
