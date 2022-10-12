using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _2589
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[,] map = new int[n[0], n[1]];
            bool[,] v = new bool[n[0], n[1]];
            for(int i = 0; i < n[0]; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < n[1]; j++)
                {
                    if (s[j] == 'W')
                    {
                        map[i, j] = -1;
                        v[i, j] = false;
                    }
                    else
                    {
                        map[i, j] = 0;
                        v[i, j] = true;
                    }
                }
            }

            int[] updown = { -1, 1, 0, 0 };
            int[] leftright = { 0, 0, -1, 1 };
            Queue<(int, int)> que = new Queue<(int, int)>();
            int ans = 0;

            for(int i = 0; i < n[0]; i++)
            {
                for(int j = 0; j < n[1]; j++)
                {
                    //벽이 아니면
                    if (map[i, j] != -1)
                    {
                        bool[,] can_visit = v.Clone() as bool[,];
                        que.Enqueue((i, j));
                        map[i, j] = 0;
                        can_visit[i, j] = false;

                        while(que.Count > 0)
                        {
                            (int, int) p = que.Dequeue();

                            for(int k = 0; k<4; k++)
                            {
                                int y = p.Item1 + updown[k];
                                int x = p.Item2 + leftright[k];

                                //범위 설정
                                if ((y >= 0 && y < n[0]) && (x >= 0 && x < n[1]))
                                {
                                    if(map[y, x] != -1 && can_visit[y,x])
                                    {
                                        map[y, x] = map[p.Item1, p.Item2] +1;
                                        can_visit[y, x] = false;
                                        que.Enqueue((y, x));
                                    }
                                }
                            }
                        }
                        
                        for (int ii = 0; ii < n[0]; ii++)
                        {
                            for (int jj = 0; jj < n[1]; jj++)
                                ans = map[ii, jj] > ans ? map[ii, jj] : ans;
                        }
                    }

                }
            }
            Console.WriteLine(ans);
        }
    }
}
