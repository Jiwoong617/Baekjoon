using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _25682
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); //n m k
            int[,] chess = new int[n[0],n[1]];
            for(int i = 0; i < n[0]; i++)
            {
                string s = Console.ReadLine();
                for(int j = 0; j < n[1]; j++)
                    chess[i,j] = s[j] == 'B' ? 1 : 0; //B = 1 , W = 0
            }

            int[,] black = new int[n[0]+1, n[1] + 1];
            int[,] white = new int[n[0]+1, n[1]+1];
            int b = 0;
            int w = 0;

            //열,행 합쳐서 2로 나눔 같은색 아님 다른색
            //왼쪽위와 같아야 되는색이 다르면 타일 변경 -> +1
            //달라야 되는 색이 같으면 타일 변경 -> +1
            for(int i = 0; i < n[0]; i++)
            {
                for(int j = 0; j < n[1]; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        b = chess[i, j] == 0 ? 1 : 0;
                        w = chess[i, j] == 1 ? 1 : 0;
                    }
                    else
                    {
                        b = chess[i, j] == 1 ? 1 : 0;
                        w = chess[i, j] == 0 ? 1 : 0;
                    }
                    black[i + 1, j + 1] = b + black[i, j + 1] + black[i + 1, j] - black[i, j];
                    white[i + 1, j + 1] = w + white[i, j + 1] + white[i + 1, j] - white[i, j];
                }
            }

            int b_count = 2000 * 2000;
            int w_count = 2000 * 2000;
            //체스판 크기만큼 잘라서 브루트포스
            for(int i = 1; i <= n[0]-n[2]+1; i++)
            {
                for(int j = 1; j <= n[1]-n[2]+1; j++)
                {
                    b_count = Math.Min(b_count, black[i + n[2] - 1, j + n[2] - 1]
                        - black[i + n[2] - 1, j - 1] - black[i - 1, j + n[2] - 1] + black[i - 1, j - 1]);
                    w_count = Math.Min(w_count, white[i + n[2] - 1, j + n[2] - 1]
                        - white[i + n[2] - 1, j - 1] - white[i - 1, j + n[2] - 1] + white[i - 1, j - 1]);
                }
            }

            Console.WriteLine(Math.Min(b_count, w_count));
        }
    }
}
