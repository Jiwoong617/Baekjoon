using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _1743
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            bool[,] map = new bool[n[0],n[1]];
            for(int i =  0; i < n[2]; i++)
            {
                int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                map[m[0]-1, m[1]-1] = true;
            }

            int[] lr = { -1, 1, 0, 0 };
            int[] ud = {0, 0, -1, 1};
            int count = 0;
            for(int i = 0; i < n[0]; i++)
            {
                for(int j = 0; j < n[1]; j++)
                {
                    if (!map[i, j]) continue;

                    int c = 1;
                    Queue<(int, int)> q = new Queue<(int, int)>();
                    q.Enqueue((i, j));
                    map[i, j] = false;
                    while(q.Count > 0)
                    {
                        var t = q.Dequeue();
                        for(int k = 0; k<4; k++)
                        {
                            int x = t.Item1 + lr[k];
                            int y = t.Item2 + ud[k];
                            if (x>=0 && y>=0 && x < n[0] && y < n[1] &&map[x,y] == true)
                            {
                                map[x, y] = false;
                                c++;
                                q.Enqueue((x, y));
                            }
                        }
                    }
                    count = Math.Max(count, c);
                }
            }
            Console.WriteLine(count);
        }
    }
}
