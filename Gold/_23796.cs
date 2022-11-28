using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _23796
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();

            long[][] arr = new long[8][];
            for (int i = 0; i < 8; i++)
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            string s = Console.ReadLine();// 입력

            List<long>[] move = new List<long>[8];
            for (int i = 0; i < 8; i++)
                move[i] = new List<long>();

            if(s == "U")
            {
                for(int i = 0; i < 8; i++)
                {
                    long choose = 0;
                    for(int j = 0; j<8; j++)
                    {
                        if (choose == 0)
                            choose = arr[j][i];
                        else
                        {
                            if (arr[j][i] != 0)
                            {
                                if (choose == arr[j][i])
                                {
                                    move[i].Add(choose * 2);
                                    choose = 0;
                                }
                                else
                                {
                                    move[i].Add(choose);
                                    choose = arr[j][i];
                                }
                            }
                        }
                    }

                    if (choose != 0)
                        move[i].Add(choose);

                    while (move[i].Count < 8)
                        move[i].Add(0);
                }
            }
            else if (s == "D")
            {
                for (int i = 0; i < 8; i++)
                {
                    long choose = 0;
                    for (int j = 7; j >= 0; j--)
                    {
                        if (choose == 0)
                            choose = arr[j][i];
                        else
                        {
                            if (arr[j][i] != 0)
                            {
                                if (choose == arr[j][i])
                                {
                                    move[i].Add(choose * 2);
                                    choose = 0;
                                }
                                else
                                {
                                    move[i].Add(choose);
                                    choose = arr[j][i];
                                }
                            }
                        }
                    }

                    if (choose != 0)
                        move[i].Add(choose);

                    while (move[i].Count < 8)
                        move[i].Add(0);

                    move[i].Reverse();
                }
            }
            else if (s == "L")
            {
                for(int i = 0; i < 8; i++)
                {
                    long choose = 0;
                    for(int j = 0; j<8; j++)
                    {
                        if (choose == 0)
                            choose = arr[i][j];
                        else
                        {
                            if (arr[i][j] != 0)
                            {
                                if (choose == arr[i][j])
                                {
                                    move[i].Add(choose * 2);
                                    choose = 0;
                                }
                                else
                                {
                                    move[i].Add(choose);
                                    choose = arr[i][j];
                                }
                            }
                        }
                    }

                    if (choose != 0)
                        move[i].Add(choose);

                    while (move[i].Count < 8)
                        move[i].Add(0);
                }
            }
            else
            {
                for(int i = 0; i<8; i++)
                {
                    long choose = 0;
                    for(int j = 7; j>=0; j--)
                    {
                        if (choose == 0)
                            choose = arr[i][j];
                        else
                        {
                            if (arr[i][j] != 0)
                            {
                                if (choose == arr[i][j])
                                {
                                    move[i].Add(choose * 2);
                                    choose = 0;
                                }
                                else
                                {
                                    move[i].Add(choose);
                                    choose = arr[i][j];
                                }
                            }
                        }
                    }

                    if (choose != 0)
                        move[i].Add(choose);

                    while (move[i].Count < 8)
                        move[i].Add(0);

                    move[i].Reverse();
                }
            }

            if(s == "U" || s == "D")
            {
                for(int i = 0; i<8; i++)
                {
                    for(int j = 0; j<8; j++)
                        stb.Append($"{move[j][i]} ");

                    stb.AppendLine();
                }
            }
            else
            {
                for(int i = 0; i< 8; i++)
                    stb.AppendLine(string.Join(" ", move[i]));
            }

            Console.WriteLine(stb);
        }
    }
}
