using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _1759
    {
        static int[] n;
        static char[] c;
        static StringBuilder stb = new StringBuilder();
        static char[] temp;
        static char[] check = { 'a', 'e', 'i', 'o', 'u' };

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            c = Array.ConvertAll(Console.ReadLine().Split(), char.Parse);
            Array.Sort(c);
            temp = new char[n[0]];

            MakePw(0, 0);
            Console.WriteLine(stb);
        }

        static void MakePw(int count, int now)
        {
            if(count >= n[0])
            {
                int num = 0;
                foreach(char ck in check)
                    num = temp.Contains(ck) ? num+1: num;

                if (num == 0 || n[0] - num < 2)
                    return;

                stb.AppendLine(string.Join("", temp));
                return;
            }

            for(int i = now; i < n[1]; i++)
            {
                temp[count] = c[i];
                MakePw(count+1, i + 1);
            }
        }
    }
}
