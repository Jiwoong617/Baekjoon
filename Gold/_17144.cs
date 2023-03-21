using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Baekjoon.Gold
{
    internal class _17144
    {
        static int[] n;
        static int[][] room;

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            room = new int[n[0]][];
            for(int i = 0; i < n[0]; i++)
                room[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            while (n[2]-- > 0)
            {
                DustInc();
                /*
                Console.WriteLine("--------------");
                for (int i = 0; i < n[0]; i++)
                    Console.WriteLine(string.Join(" ", room[i]));
                Console.WriteLine("--------------");
                */
                AirClean();
                /*
                Console.WriteLine("--------------");
                for (int i = 0; i < n[0]; i++)
                    Console.WriteLine(string.Join(" ", room[i]));
                Console.WriteLine("--------------");
                */
            }

            int ans = 0;
            for(int i = 0; i < n[0]; i++)
            {
                for(int j = 0; j< n[1]; j++)
                {
                    if (room[i][j] == -1 || room[i][j] == 0)
                        continue;

                    ans += room[i][j];
                }
            }
            Console.WriteLine(ans);
        }

        static void DustInc()
        {
            Queue<(int, int, int)> que = new Queue<(int, int, int)> ();
            for(int i = 0; i < n[0]; i++)
            {
                for(int j = 0; j < n[1]; j++)
                {
                    if (room[i][j] == 0 || room[i][j] == -1)
                        continue;

                    int count = 0;
                    int dust = room[i][j]/5;
                    if(i+1 < n[0] && room[i + 1][j] != -1)
                    {
                        count++;
                        que.Enqueue((i + 1, j, dust));
                    }
                    if(i-1 >= 0 && room[i - 1][j] != -1)
                    {
                        count++;
                        que.Enqueue((i - 1, j, dust));
                    }
                    if(j+1 < n[1] && room[i][j+1] != -1)
                    {
                        count++;
                        que.Enqueue((i, j+1, dust));
                    }
                    if(j-1 >=0 && room[i][j-1] != -1)
                    {
                        count++;
                        que.Enqueue((i, j-1, dust));
                    }

                    room[i][j] -= count * dust;
                }
            }

            while(que.Count > 0)
            {
                var dust = que.Dequeue();
                room[dust.Item1][dust.Item2] += dust.Item3;
            }
        }

        static void AirClean()
        {
            Queue<(int, int, int)> que = new Queue<(int, int, int)>();
            (int, int) air = (2, 3);

            for (int i = 0; i < n[1]; i++)
            {
                que.Enqueue((0, i, room[0][i]));
                que.Enqueue((n[0] - 1, i, room[n[0] - 1][i]));
            }

            for (int i = 1; i < n[0]-1; i++)
            {
                if (room[i][0] == -1)
                {
                    air = (i-1, i);
                    for (int j = 1; j < n[1]; j++)
                        que.Enqueue((i, j, room[i][j]));

                    continue;
                }

                que.Enqueue((i, 0, room[i][0]));
                que.Enqueue((i, n[1]-1, room[i][n[1] -1]));
            }

            while (que.Count > 0)
            {
                var dust = que.Dequeue();

                if(dust.Item1 == air.Item1)
                {
                    if(dust.Item2+1 < n[1])
                        room[dust.Item1][dust.Item2+1] = dust.Item3;
                    else
                        room[dust.Item1-1][dust.Item2] = dust.Item3;
                }
                else if(dust.Item1 == air.Item2)
                {
                    if (dust.Item2 + 1 < n[1])
                        room[dust.Item1][dust.Item2 + 1] = dust.Item3;
                    else
                        room[dust.Item1 + 1][dust.Item2] = dust.Item3;
                }
                else if(dust.Item1 == 0)
                {
                    if(dust.Item2-1 >= 0)
                        room[dust.Item1][dust.Item2-1] = dust.Item3;
                    else
                        room[dust.Item1+1][dust.Item2] = dust.Item3;
                }
                else if(dust.Item1 == n[0] - 1)
                {
                    if (dust.Item2 - 1 >= 0)
                        room[dust.Item1][dust.Item2 - 1] = dust.Item3;
                    else
                        room[dust.Item1-1][dust.Item2] = dust.Item3;
                }
                else if(dust.Item1 < air.Item1)
                {
                    if (dust.Item2 == n[1] - 1)
                        room[dust.Item1 - 1][dust.Item2] = dust.Item3;
                    else
                    {
                        if (room[dust.Item1 + 1][dust.Item2] != -1)
                            room[dust.Item1 + 1][dust.Item2] = dust.Item3;
                    }
                }
                else if(dust.Item1 > air.Item2)
                {
                    if (dust.Item2 == n[1] - 1)
                        room[dust.Item1 + 1][dust.Item2] = dust.Item3;
                    else
                    {
                        if (room[dust.Item1 - 1][dust.Item2] != -1)
                            room[dust.Item1 - 1][dust.Item2] = dust.Item3;
                    }
                }
            }
            room[air.Item1][1] = 0;
            room[air.Item2][1] = 0;
        }
    }
}
