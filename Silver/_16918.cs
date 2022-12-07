using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _16918
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();

            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            char[,] map = new char[n[0], n[1]];

            Queue<(int, int)> bomb = new Queue<(int, int)>(); //터질 곳

            for(int i = 0; i < n[0]; i++)
            {
                string s = Console.ReadLine();

                for (int j = 0; j< n[1]; j++)
                {
                    map[i, j] = s[j];
                    if (s[j] == 'O')
                        bomb.Enqueue((i, j));
                }
            }

            int bombcount = bomb.Count;
            int[] updown = { -1, 1, 0, 0 };
            int[] leftrignt = { 0, 0, -1, 1 };

            //첫번째 폭탄 터짐
            for (int i = 0; i<bombcount; i++)
            {
                (int, int) point = bomb.Dequeue();

                for(int j = 0; j< 4; j++)
                {
                    int x = point.Item1 + updown[j];
                    int y = point.Item2 + leftrignt[j];
                    if (x >= 0 && x < n[0] && y >= 0 && y < n[1])
                        bomb.Enqueue((x, y));
                }
                bomb.Enqueue(point);
            }

            char[][] firstbomb = new char[n[0]][];
            for (int i = 0; i < n[0]; i++)
                firstbomb[i] = Enumerable.Repeat('O', n[1]).ToArray();

            while (bomb.Count > 0)
            {
                (int, int) p = bomb.Dequeue();
                firstbomb[p.Item1][p.Item2] = '.';
            }

            //두번째 폭탄 터짐
            Queue<(int, int)> bomb2 = new Queue<(int, int)>();
            for(int i = 0; i< n[0]; i++)
            {
                for(int j = 0; j < n[1]; j++)
                {
                    if (firstbomb[i][j] == 'O')
                        bomb2.Enqueue((i, j));
                }
            }

            bombcount = bomb2.Count;
            for (int i = 0; i < bombcount; i++)
            {
                (int, int) point = bomb2.Dequeue();

                for (int j = 0; j < 4; j++)
                {
                    int x = point.Item1 + updown[j];
                    int y = point.Item2 + leftrignt[j];
                    if (x >= 0 && x < n[0] && y >= 0 && y < n[1])
                        bomb2.Enqueue((x, y));
                }
                bomb2.Enqueue(point);
            }

            char[][] secondbomb = new char[n[0]][];
            for (int i = 0; i < n[0]; i++)
                secondbomb[i] = Enumerable.Repeat('O', n[1]).ToArray();

            while (bomb2.Count > 0)
            {
                (int, int) p = bomb2.Dequeue();
                secondbomb[p.Item1][p.Item2] = '.';
            }

            //4초마다 반복
            if (n[2] % 2 == 0)
            {
                char[] c = Enumerable.Repeat('O', n[1]).ToArray();
                for (int i = 0; i < n[0]; i++)
                    stb.AppendLine(string.Join("", c));
            }
            else if (n[2] == 1)
            {
                for(int i = 0; i< n[0]; i++)
                {
                    for (int j = 0; j < n[1]; j++)
                        stb.Append(map[i, j]);
                    stb.AppendLine();
                }
            }
            else if (n[2] % 4 == 3)
            {
                for (int i = 0; i < n[0]; i++)
                    stb.AppendLine(string.Join("", firstbomb[i]));
            }
            else if (n[2] % 4 == 1)
            {
                for (int i = 0; i < n[0]; i++)
                    stb.AppendLine(string.Join("", secondbomb[i]));
            }

            Console.WriteLine(stb);
        }
    }
}
