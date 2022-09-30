using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Gold
{
    class _12865
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] things = new int[n[0]][];
            for(int i = 0; i<n[0]; i++)
                things[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //0으로 초기화 - 행: 물건의 개수, 열: 배낭의 무게
            int[][] backpack = new int[n[0]+1][];
            for (int i = 0; i <=n[0]; i++)
                backpack[i] = Enumerable.Repeat(0, n[1]+1).ToArray();

            for (int i = 1; i<=n[0]; i++)
            {
                for(int j = 1; j<=n[1]; j++)
                {
                    //물건의 무게가 배낭에 들어가면
                    if (things[i - 1][0] <= j)
                        //현 무게에 해당하는 전물건의 가치, 무게가(현가방무게 - 현물건무게)인 가치 + 현물건의 가치 비교
                        backpack[i][j] = Math.Max(backpack[i - 1][j], backpack[i - 1][j - things[i - 1][0]] + things[i - 1][1]);
                    //안들어가면 그냥 전물건의 가치 적용
                    else
                        backpack[i][j] = backpack[i - 1][j];
                }
            }
            Console.WriteLine(backpack[n[0]][n[1]]);
        }
    }
}
