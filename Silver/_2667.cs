using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Baekjoon.silver
{
    class _2667
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] apart = new int[n, n];
            for(int i = 0; i<n; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < n; j++)
                    apart[i, j] = int.Parse(s[j].ToString());
            }

            int count;
            List<int> list = new List<int>();
            int[] updown = { -1, 1, 0, 0 };
            int[] leftright = { 0, 0, -1, 1 };
            Queue<(int, int)> que = new Queue<(int, int)>();

            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    if(apart[i, j] == 1)
                    {
                        count = 1;
                        que.Enqueue((i, j));
                        apart[i, j] = 0;

                        while (que.Count > 0)
                        {
                            (int, int) temp = que.Dequeue();
                            for(int k = 0; k<4; k++)
                            {
                                int x = temp.Item1 + updown[k];
                                int y = temp.Item2 + leftright[k];

                                if((x>=0 && x < n) && (y >= 0 && y < n))
                                {
                                    if (apart[x,y] == 1)
                                    {
                                        apart[x,y] = 0;
                                        que.Enqueue((x, y));
                                        count++;
                                    }
                                }
                            }
                        }
                        list.Add(count);
                    }
                }
            }
            list.Sort();
            Console.WriteLine(list.Count);
            Console.WriteLine(string.Join("\n", list));
        }
    }
}
