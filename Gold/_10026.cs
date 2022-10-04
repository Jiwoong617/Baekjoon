using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _10026
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] paint = new char[n,n];
            char[,] b_paint = new char[n,n];
            bool[,] visit = new bool[n,n]; //정상인 방문했는지
            bool[,] b_visit = new bool[n,n]; //색약 방문 표시
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    paint[i, j] = s[j];
                    //색약을 위한 그래프
                    if (s[j] == 'R' || s[j] =='G')
                        b_paint[i, j] = 'A';
                }
            }

            //상하 좌우
            int[] updown = { -1, 1, 0, 0 };
            int[] leftright = { 0, 0, -1, 1};
            int normal = 0; //정상인
            int blind = 0; //적록색약
            Queue<(int,int)> que = new Queue<(int,int)>();
            Queue<(int,int)> blind_que = new Queue<(int,int)>();

            char rgb;
            char blind_rgb;
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    //정상인
                    rgb = paint[i, j];
                    if (!visit[i, j])
                    {
                        visit[i, j] = true;
                        que.Enqueue((i,j));
                        normal++;
                    }

                    while (que.Count > 0)
                    {
                        (int, int) point = que.Dequeue();

                        for(int k = 0; k<4; k++)
                        {
                            int y = point.Item1 + updown[k];
                            int x = point.Item2 + leftright[k];
                            //범위 안
                            if ((y<n && y>=0) &&(x<n && x >= 0))
                            {
                                if (paint[y,x] == rgb && !visit[y, x])
                                {
                                    visit[y, x] = true;
                                    que.Enqueue((y,x));
                                }
                            }
                        }
                    }

                    //적록 색맥
                    blind_rgb = b_paint[i, j];
                    if (!b_visit[i, j])
                    {
                        b_visit[i, j] = true;
                        blind_que.Enqueue((i, j));
                        blind++;
                    }

                    while (blind_que.Count > 0)
                    {
                        (int, int) point = blind_que.Dequeue();

                        for (int k = 0; k < 4; k++)
                        {
                            int y = point.Item1 + updown[k];
                            int x = point.Item2 + leftright[k];
                            //범위 안
                            if ((y < n && y >= 0) && (x < n && x >= 0))
                            {
                                if (b_paint[y, x] == blind_rgb && !b_visit[y, x])
                                {
                                    b_visit[y, x] = true;
                                    blind_que.Enqueue((y, x));
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"{normal}\n{blind}");
        }
    }
}
