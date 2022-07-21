using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1358
    {
        static void Main(string[] args)
        {
            int[] pos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;

            for(int i = 0; i<pos[4]; i++)
            {
                int[] man = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                double left = Math.Sqrt(Math.Pow(man[0] - pos[2], 2) + Math.Pow(man[1] - (pos[3]+pos[1]/2), 2));
                double right = Math.Sqrt(Math.Pow(man[0] - (pos[2]+pos[0]), 2) + Math.Pow(man[1] -(pos[3]+ pos[1] / 2), 2));

                if (man[0] >= pos[2] && man[0] <= pos[2] + pos[0] && man[1] >= pos[3] && man[1] <= pos[3] + pos[1])
                    count++;
                else if (pos[1] / 2 >= left || pos[1] / 2 >= right)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
