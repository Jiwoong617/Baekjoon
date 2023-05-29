using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _6603
    {
        static int[] n;
        static StringBuilder stb = new StringBuilder();
        static int[] temp = new int[6];

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            while (n.Length != 1 || n[0] != 0)
            {
                n = n[1..n.Length];
                BacKT(0, 0);

                stb.AppendLine();
                n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            Console.WriteLine(stb);
        }

        static void BacKT(int now, int count)
        {
            if(count == 6)
            {
                stb.AppendLine(string.Join(" ", temp));
                return;
            }

            for(int i = now; i<n.Length; i++)
            {
                temp[count] = n[i];
                BacKT(i + 1, count+1);
            }
        }
    }
}
