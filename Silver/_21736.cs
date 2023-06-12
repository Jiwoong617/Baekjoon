using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _21736
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string[] s = new string[n[0]];
            bool[][] visited = new bool[n[0]][];
            (int, int) pos = (0, 0);
            for (int i = 0; i < n[0]; i++)
            {
                s[i] = Console.ReadLine();
                visited[i] = new bool[n[1]];
                int yPos = s[i].IndexOf('I');
                if (yPos > -1)
                {
                    pos = (i, yPos);
                    visited[i][yPos] = true;
                }
            }

            int[] ud = { -1, 1, 0, 0 };
            int[] lr = { 0, 0, -1, 1 };
            Queue<(int, int)> q = new Queue<(int, int)>();
            q.Enqueue(pos);
            int count = 0;
            while (q.Count > 0)
            {
                var t = q.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int x = t.Item1 + ud[i];
                    int y = t.Item2 + lr[i];
                    if (x >= 0 && y >= 0 && x < n[0] && y < n[1])
                    {
                        if (!visited[x][y] && s[x][y] != 'X')
                        {
                            q.Enqueue((x, y));
                            visited[x][y] = true;
                            if (s[x][y] == 'P')
                                count++;
                        }
                    }
                }
            }

            Console.WriteLine(count == 0 ? "TT" : count);
        }
    }
}
