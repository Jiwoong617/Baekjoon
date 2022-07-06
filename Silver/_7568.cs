using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _7568
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[][] human = new int[num][];
            int dungchi = 0;

            for (int i = 0; i < num; i++)
            {
                human[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            for(int i = 0; i<num; i++)
            {
                dungchi = 1;
                for(int j = 0; j<num; j++)
                {
                    if (human[i][0] < human[j][0] && human[i][1] < human[j][1])
                        dungchi++;
                }
                Console.Write($"{dungchi} ");
            }
        }
    }
}
