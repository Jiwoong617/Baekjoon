using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _2775
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i<n; i++)
            {
                int floor = int.Parse(Console.ReadLine());
                int ho = int.Parse(Console.ReadLine());
                int[,] room = new int[floor+1, ho];

                for (int j = 0; j < ho; j++) //0층 1 2 3 4
                    room[0, j] = j + 1;
                for (int j = 0; j <= floor; j++) //각층 1호실은 모두 1명
                    room[j, 0] = 1;

                for (int j =1; j<=floor; j++)
                {
                    for (int k = 1; k<ho; k++)
                    {
                        room[j, k] = room[j, k - 1] + room[j - 1, k];
                    }
                }
                Console.WriteLine(room[floor, ho - 1]);
            }
        }
    }
}
