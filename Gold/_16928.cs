using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _16928
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] board = new int[101];
            bool[] visit = new bool[101];

            //보드에 사다리/뱀 정보 저장
            for(int i = 0; i < n[0] + n[1]; i++)
            {
                int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                board[m[0]] = m[1];
            }

            //bfs
            Queue<int> que = new Queue<int>();
            visit[1] = true;
            que.Enqueue(1);
            while(que.Count > 0)
            {
                //현재 위치
                int now = que.Dequeue();

                for(int i = 1; i<=6; i++)
                {
                    //주사위를 굴렸을 때 위치가 100넘으면 끊기
                    if (now + i > 100)
                        break;

                    int dice;
                    //만약 뱀이나 사다리 없으면 현재 위치
                    if (board[now + i] == 0)
                        dice = now + i;
                    //뱀이나 사다리 있으면 그걸로 가기
                    else
                        dice = board[now + i];

                    //방문 안했으면
                    if (!visit[dice])
                    {
                        visit[dice] = true;
                        //현재 몇번짼지 = 굴린위치 +1
                        board[dice] = board[now]+1;
                        //굴릴 위치 넣어주기.
                        que.Enqueue(dice);
                    }
                }
            }

            //Console.WriteLine(string.Join(" ", board));
            Console.WriteLine(board[100]);
        }
    }
}
