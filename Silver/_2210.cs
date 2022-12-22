using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    class _2210
    {
        static int[][] arr = new int[5][];
        static int[] leftright = { -1, 1, 0, 0 };
        static int[] updown = { 0, 0, -1, 1 };
        static List<int> list = new List<int>();

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


            for(int i = 0; i< 5; i++)
            {
                for(int j = 0; j<5; j++)
                {
                    int count = 5;
                    dfs(arr[i][j], count, (i, j));
                }
            }

            Console.WriteLine(list.Count);
        }

        static void dfs(int num, int count, (int,int) location)
        {
            if(count <= 0)
            {
                if (!list.Contains(num))
                    list.Add(num);

                return;
            }

            for(int i = 0; i<4; i++)
            {
                int x = location.Item1 + leftright[i];
                int y = location.Item2 + updown[i];

                if ((x >= 0 && x < 5) && (y >= 0 && y < 5))
                {
                    dfs(num * 10 + arr[x][y], count-1, (x, y));
                }
            }
        }
    }
}
