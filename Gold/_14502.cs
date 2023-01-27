using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _14502
    {
        static int[] nm;
        static int[,] lab;
        static Queue<(int, int)> q = new Queue<(int, int)>();
        static int[] ud = { -1, 1, 0, 0 };
        static int[] lr = { 0, 0, -1, 1 };
        static int ans = 0;

        static void Main(string[] args)
        {
            nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            lab = new int[nm[0],nm[1]];

            for(int i = 0; i < nm[0]; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j = 0; j <nm[1] ; j++)
                {
                    lab[i,j] = arr[j];
                    if (lab[i,j] == 2)
                        q.Enqueue((i,j));
                }
            }

            Barricade(1);
            Console.WriteLine(ans);
        }

        static void Bfs()
        {
            int[,] testLab = lab.Clone() as int[,];
            Queue<(int, int)> que = new Queue<(int, int)>(q);

            while(que.Count > 0)
            {
                (int, int) temp = que.Dequeue();
                for(int i = 0; i< 4; i++)
                {
                    int x = temp.Item1 + ud[i];
                    int y = temp.Item2 + lr[i];

                    if((x >= 0 && x < nm[0]) && (y>=0 && y < nm[1]))
                    {
                        if (testLab[x, y] == 0)
                        {
                            testLab[x, y] = 2;
                            que.Enqueue((x,y));
                        }
                    }
                }
            }

            int count = 0;
            for(int i = 0; i < nm[0]; i++)
            {
                for(int j = 0; j < nm[1]; j++)
                {
                    if (testLab[i, j] == 0)
                        count++;
                }
            }

            ans = Math.Max(count, ans);
        }

        static void Barricade(int count)
        {
            if (count > 3)
            {
                Bfs();
                return;
            }

            for (int i = 0; i < nm[0]; i++)
            {
                for(int j = 0; j < nm[1]; j++)
                {
                    if (lab[i,j] == 0)
                    {
                        lab[i, j] = 1;
                        Barricade(count + 1);
                        lab[i, j] = 0;
                    }
                }
            }
        }
    }
}
