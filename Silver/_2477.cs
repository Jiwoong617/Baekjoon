using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _2477
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] square = new int[6][];
            int[] direct = Enumerable.Repeat(0, 4).ToArray();
            int big = 1;
            int small = 0;

            for(int i = 0; i<6; i++)
            {
                square[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                direct[square[i][0]-1]++;
            }

            for(int i = 0; i<6; i++)
            {
                if (direct[square[i][0]-1] == 1)
                    big *= square[i][1];

                else
                {
                    if(square[i][0] == square[(i + 2)%6][0] && square[(i+1)%6][0] == square[(i+3)%6][0])
                        small = square[(i + 1)%6][1] * square[(i + 2)%6][1];
                }
            }

            Console.WriteLine((big-small)*n);
        }
    }
}
