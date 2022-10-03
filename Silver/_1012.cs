using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _1012
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int count;
            int[] updown = { -1, 1, 0, 0 };
            int[] leftright = { 0, 0, -1, 1 };
            
            for(int i = 0; i<n; i++)
            {
                count = 0;
                //m[0] 가로, m[1] 세로, m[2]개수
                int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                //농장 0, false으로 초기화
                int[,] farm = new int[m[0],m[1]];
                bool[,] visit = new bool[m[0],m[1]];

                //배추 있는곳 1로 표기
                for (int j = 0; j<m[2]; j++)
                {
                    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    farm[b[0],b[1]] = 1;
                }

                Queue<(int,int)> que = new Queue<(int,int)>();
                //일단 첨부터 끝까지
                for(int a = 0; a<m[0]; a++)
                {
                    for(int b = 0; b<m[1]; b++)
                    {
                        //방문 x, 배추 있으면 bfs
                        if(!visit[a,b] && farm[a,b] == 1)
                        {
                            que.Enqueue((a, b));
                            visit[a,b] = true;
                            count++;
                            while(que.Count > 0)
                            {
                                (int, int) point = que.Dequeue();
                                for(int k = 0; k<4; k++)
                                {
                                    int y = point.Item1 + updown[k];
                                    int x = point.Item2 + leftright[k];
                                    if((y<m[0]&& y>=0) && (x<m[1] && x >= 0))
                                    {
                                        if(farm[y,x] == 1 && !visit[y,x])
                                        {
                                            visit[y,x] = true;
                                            que.Enqueue((y, x));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                stb.AppendLine(count.ToString());
            }
            Console.WriteLine(stb);
        }
    }
}
