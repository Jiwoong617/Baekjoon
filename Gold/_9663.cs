using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Gold
{
    class _9663
    {
        static int n;
        static int count = 0;
        static int[] chess;
        //static StringBuilder stb = new StringBuilder();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            chess = new int[n];
            queen(0);
            Console.WriteLine(count);
            //Console.WriteLine(stb);
        }

        static void queen(int num)
        {
            if(num == n)
            {
                count++;
                return;
            }

            //num = 행값 , i = 열값
            //즉 chess[num] = 0 이면 num행, i열에 퀸을 두었다는 뜻
            for(int i = 0; i< n; i++)
            {
                chess[num] = i;
                bool put = true;
                //stb.AppendLine(String.Join(" ", chess));
                for (int j = 0; j<num; j++)
                {
                    //같은 행에 있으면 안됨.
                    if (chess[num] == chess[j])
                    {
                        put = false;
                        break;
                    }
                    //두 점의 열의 차, 행의 차의 절대값이 같으면 대각선임
                    //ex1) 우하향 대각선 -> (1,2) (2,3) (3,4) (4,5)
                    //ex2) 좌하향 대각선 -> (1,5) (2,4) (3,3) (4,2) 
                    //절대값(x1 - x2) = 절대값(y1 - y2)가 전부 같다.
                    //퀸은 행,열,대각선으로 움직이니 대각선에도 있으면 안된다.
                    else if (Math.Abs(chess[j] - chess[num]) == Math.Abs(j-num))
                    {
                        put = false;
                        break;
                    }
                }

                if (put)
                    queen(num + 1);
            }
        }
    }
}
