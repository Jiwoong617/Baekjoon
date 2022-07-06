using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1018
    {
        static void Main(string[] args)
        {
            int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string[] chess = new string[num[0]];
            int count = 0;
            int max = 64;
            for (int i = 0; i < num[0]; i++)
                chess[i] = Console.ReadLine();

            for(int i =0; i<=num[0] - 8; i++)
            {
                for (int j = 0; j<=num[1]- 8; j++)
                {
                    count = 0;
                    for(int x = i; x<i+8; x++)
                    {
                        for(int y = j; y<j+8; y++)
                        {
                            if(chess[i][j] == 'W')
                            {
                                if((i+j) %2 == (x + y) % 2)
                                {
                                    if (chess[x][y] == 'B')
                                        count++;
                                }
                                else
                                {
                                    if (chess[x][y] == 'W')
                                        count++;
                                }
                            }
                            else 
                            {
                                if ((i + j) % 2 == (x + y) % 2)
                                {
                                    if (chess[x][y] == 'W')
                                        count++;
                                }
                                else
                                {
                                    if (chess[x][y] == 'B')
                                        count++;
                                }
                            }
                        }
                    }
                    if (count > 64 - count) //반대로 하는 경우가 더 적게 칠할때를 위해
                        count = 64 - count;
                    if(count < max)
                    {
                        max = count;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
