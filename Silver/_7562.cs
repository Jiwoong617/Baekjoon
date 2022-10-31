using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _7562
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            (int, int)[] move = { (-2, -1), (-2, 1), (-1, -2), (-1, 2), (2, -1), (2, 1), (1, -2), (1, 2) };

            int t = int.Parse(Console.ReadLine());
            for(int test = 0; test<t; test++)
            {
                int size = int.Parse(Console.ReadLine());
                int[,] chess = new int[size, size];

                int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                chess[n[0], n[1]] = 1;

                int[] destination = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                Queue<(int, int)> que = new Queue<(int, int)>();
                que.Enqueue((n[0], n[1]));
                while(que.Count > 0)
                {
                    (int, int) temp = que.Dequeue();
                    for(int i = 0; i<8; i++)
                    {
                        int x = temp.Item1 + move[i].Item1;
                        int y = temp.Item2 + move[i].Item2;

                        if ((x >= 0 && x<size) && (y>= 0 && y < size))
                        {
                            if (chess[x,y] == 0)
                            {
                                que.Enqueue((x,y));
                                chess[x, y] = chess[temp.Item1, temp.Item2] + 1;
                            }
                        }
                    }

                    if (chess[destination[0], destination[1]] != 0)
                        break;
                }

                stb.AppendLine((chess[destination[0], destination[1]]-1).ToString());
            }

            Console.WriteLine(stb);
        }
    }
}
