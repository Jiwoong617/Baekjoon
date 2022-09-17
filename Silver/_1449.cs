using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.silver
{
    class _1449
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int tape = n[1];
            int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(m);

            float fix = m[0] - 0.5f;
            int count = 0;
            for(int i= 0; i<n[0]; i++)
            {
                if((float)(fix + tape) < m[i])
                {
                    fix = m[i] - 0.5f;
                    count++;
                }
            }
            Console.WriteLine(count+1);
        }
    }
}
