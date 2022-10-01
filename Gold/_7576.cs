using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Gold
{
    class _7576
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //n[0]: 열, n[1] = 행
            int[][] box = new int[n[1]][];

            //que(x, y)
            Queue<(int, int)> que = new Queue<(int, int)>(); 
            for(int i = 0; i<n[1]; i++)
            {
                box[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j = 0; j<n[0]; j++)
                {
                    //일단 1이면 큐에 넣어버리기
                    if (box[i][j] == 1)
                        que.Enqueue((i, j));
                }
            }

            int count = 0;
            int[] updown = {-1, 1, 0, 0};
            int[] leftright = {0, 0, -1, 1};
            while(que.Count > 0)
            {
                (int,int) point = que.Dequeue();
                int x = point.Item1;
                int y = point.Item2;

                for(int i = 0; i<4; i++)
                {
                    //인덱스 값 벗어날 수 있으니 범위 설정
                    if ((x+updown[i] < n[1] && x+updown[i] >= 0) && (y+leftright[i] < n[0] && y+leftright[i] >= 0))
                    {
                        //안익었으면 익게 만들고 큐에 넣기
                        if(box[x + updown[i]][y + leftright[i]] == 0)
                        {
                            box[x + updown[i]][y + leftright[i]] = box[x][y]+1;
                            count = box[x][y];
                            que.Enqueue((x + updown[i], y + leftright[i]));
                        }
                    }
                }
            }

            for(int i = 0; i< n[1]; i++)
            {
                for(int j = 0; j<n[0]; j++)
                {
                    if (box[i][j] == 0)
                    {
                        count = -1;
                        break;
                    }
                }
                if (count == -1)
                    break;
            }

            Console.WriteLine(count);
        }
    }
}
