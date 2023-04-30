using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _2583
    {
        static int[] n;
        static bool[,] g;
        static int count;
        static int[] ud = { -1, 1, 0, 0 };
        static int[] lr = { 0, 0, -1, 1 };

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            g = new bool[n[0], n[1]];
            while (n[2]-- > 0)
            {
                int[] div = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int i = div[1]; i < div[3]; i++)
                {
                    for(int j = div[0]; j<div[2]; j++)
                        g[i,j] = true;
                }
            }

            List<int> list = new List<int>();
            for(int i = 0; i < n[0]; i++)
            {
                for(int j = 0; j < n[1]; j++)
                {
                    if (g[i, j])
                        continue;

                    list.Add(BFS(i, j));
                    count++;
                }
            }

            Console.WriteLine($"{count}\n{string.Join(" ",list.OrderBy(x=>x))}");
        }

        static int BFS(int x, int y)
        {
            int area = 1;
            Queue<(int, int)> q= new Queue<(int, int)>();
            q.Enqueue((x, y));
            g[x, y] = true;

            while(q.Count> 0)
            {
                var p = q.Dequeue();
                for(int i = 0; i<4; i++)
                {
                    int px = p.Item1 + ud[i];
                    int py = p.Item2 + lr[i];
                    if(px>= 0 && py>= 0 && px < n[0] && py < n[1] && !g[px, py])
                    {
                        area++;
                        g[px, py] = true;
                        q.Enqueue((px, py));
                    }
                }
            }

            return area;
        }
    }
}
