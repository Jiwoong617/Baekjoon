using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _2178
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[,] maze = new int[n[0], n[1]];
            bool[,] visited = new bool[n[0], n[1]];
            for(int i = 0; i < n[0]; i++)
            {
                string s = Console.ReadLine();
                for(int j = 0; j < n[1]; j++)
                {
                    maze[i, j] = int.Parse(s[j].ToString());
                    if (maze[i, j] == 1)
                        visited[i, j] = false;
                    else
                        visited[i, j] = true;

                }
            }

            int[] updown = { -1, 1, 0, 0 };
            int[] leftright = { 0, 0, -1, 1 };
            Queue<(int, int)> que = new Queue<(int, int)>();
            que.Enqueue((0, 0));
            visited[0, 0] = true;

            while(que.Count > 0)
            {
                (int, int) temp = que.Dequeue();
                for(int i = 0; i< 4; i++)
                {
                    int x = temp.Item1 + updown[i];
                    int y = temp.Item2 + leftright[i];
                    if((x>=0 && x < n[0])&&(y>=0 && y < n[1]))
                    {
                        if (!visited[x, y])
                        {
                            visited[x, y] = true;
                            maze[x, y] = maze[temp.Item1, temp.Item2] + 1;
                            que.Enqueue((x, y));
                        }
                    }
                }
            }

            Console.WriteLine(maze[n[0] - 1, n[1] - 1]);
        }
    }
}
