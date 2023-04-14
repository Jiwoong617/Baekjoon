using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.Gold
{
    internal class _14891
    {
        static List<int>[] gear = new List<int>[5];
        static int[] check = new int[5];

        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                gear[i] = new List<int>();
                string s = Console.ReadLine();

                for (int j = 0; j < 8; j++)
                    gear[i].Add(int.Parse(s[j].ToString()));
            }

            int n = int.Parse(Console.ReadLine());
            while(n-- > 0)
            {
                int[] rotate = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                CheckRotate(rotate[0], rotate[1]);
                Rotate();
            }

            Console.WriteLine(Score());
        }

        static void CheckRotate(int n, int dir)
        {
            // -1 반시계 1 시계 0 그대로
            check = check.Select(x => x = 0).ToArray();
            check[n] = dir;

            //left
            for(int i = n-1; i>0; i--)
            {
                if (gear[i + 1][6] == gear[i][2])
                    break;

                check[i] = check[i + 1] * -1;
            }

            //right
            for(int i = n+1; i<5; i++)
            {
                if (gear[i - 1][2] == gear[i][6])
                    break;

                check[i] = check[i-1] * -1;
            }
        }

        static void Rotate()
        {
            for(int i = 1; i < 5; i++)
            {
                if (check[i] == 1)
                {
                    gear[i].Insert(0, gear[i][7]);
                    gear[i].RemoveAt(8);
                }
                else if (check[i] == -1)
                {
                    gear[i].Add(gear[i][0]);
                    gear[i].RemoveAt(0);
                }
            }
        }

        static int Score()
        {
            int score = 0;
            if (gear[1][0] == 1)
                score += 1;
            if (gear[2][0] == 1)
                score += 2;
            if (gear[3][0] == 1)
                score += 4;
            if (gear[4][0] == 1)
                score += 8;

            return score;
        }
    }
}
