using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _4963
    {
        static int[] ud = { -1, 1, 0, 0, -1, -1, 1, 1 };
        static int[] lr = { 0, 0, -1, 1, 1, -1, 1, -1 };

        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            StringBuilder stb = new StringBuilder();
            while (true)
            {
                int[][] map = new int[n[1]][];
                for(int i = 0; i < n[1]; i++)
                    map[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                int count = 0;
                for(int i = 0; i < n[1];i++)
                {
                    for(int j = 0; j < n[0]; j++)
                    {
                        if (map[i][j] == 0)
                            continue;

                        Queue<(int, int)> q = new Queue<(int, int)>();
                        q.Enqueue((i, j));
                        map[i][j] = 0;
                        while(q.Count > 0)
                        {
                            var t = q.Dequeue();

                            for(int k = 0; k<8; k++)
                            {
                                int x = t.Item1 + ud[k];
                                int y = t.Item2 + lr[k];
                                if(x>= 0 && y>=0 && x < n[1] && y < n[0])
                                {
                                    if (map[x][y] == 1)
                                    {
                                        q.Enqueue((x, y));
                                        map[x][y] = 0;
                                    }
                                }
                            }
                        }
                        count++;
                    }
                }
                stb.AppendLine(count.ToString());

                n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (n[0] == 0 && n[1] == 0)
                    break;
            }
            Console.WriteLine(stb);
        }
    }
}
