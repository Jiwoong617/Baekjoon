using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _16236
    {
        static int n;
        static (int, int) sharkpos;
        static int size;
        static int eat;
        static int[,] fish;
        static int[,] distance;
        static int ans;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            fish = new int[n,n];
            distance = new int[n, n];
            size = 2;
            eat = 0;
            ans = 0;

            for(int i = 0; i<n; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j = 0; j<n; j++)
                {
                    fish[i,j] = arr[j];
                    if (arr[j] == 9)
                        sharkpos = (i, j);
                }
            }

            while (true)
            {
                if (!bfs())
                    break;
            }
            Console.WriteLine(ans);
        }

        static bool bfs()
        {
            Queue<(int, int)> que = new Queue<(int, int)>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    distance[i,j] = -1;
            }
            distance[sharkpos.Item1,sharkpos.Item2] = 0;

            que.Enqueue((sharkpos.Item1, sharkpos.Item2));
            int[] lr = { -1, 1, 0, 0 };
            int[] ud = { 0, 0, -1, 1 };

            while (que.Count > 0)
            {
                (int, int) temp = que.Dequeue();
                for(int i = 0; i< 4; i++)
                {
                    int x = temp.Item1 + ud[i];
                    int y = temp.Item2 + lr[i];
                    if((x >= 0 && x< n) && (y >= 0 && y < n) && distance[x, y] == -1 && fish[x,y] <= size)
                    {
                        distance[x, y] = distance[temp.Item1, temp.Item2] + 1;
                        que.Enqueue((x, y));
                    }
                }
            }

            int minx = 0;
            int miny = 0;
            int dis = 400;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (fish[i, j] != 0 && fish[i, j] != 9 && fish[i, j] < size && distance[i, j] <= dis && distance[i,j] != -1)
                    {
                        dis = distance[i, j];
                        minx = i;
                        miny = j;
                    }
                }
            }

            if (dis == 400)
                return false;
            else
            {
                fish[sharkpos.Item1, sharkpos.Item2] = 0;
                sharkpos = (minx, miny);
                fish[minx, miny] = 9;
                eat++;
                if (eat == size)
                {
                    size++;
                    eat = 0;
                }
                ans += dis;
                return true;
            }
        }
    }
}
