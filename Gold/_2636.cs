using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _2636
    {
        static int[] n;
        static int[][] cheese;
        static bool[][] isOut;
        static int[] ud = { 1, -1, 0, 0 };
        static int[] lr = { 0, 0, 1, -1 };
        static int time = 0;
        static List<int> cheeseCount = new List<int>();

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            cheese = new int[n[0]][];
            isOut = new bool[n[0]][];
            for (int i = 0; i < n[0]; i++)
            {
                cheese[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                isOut[i] = new bool[n[1]];
            }

            while (true)
            {
                InOut_Air();
                if (!Timer())
                    break;
            }

            int cCount = cheeseCount.Count > 1 ? cheeseCount[cheeseCount.Count - 2] : cheeseCount[0];
            Console.WriteLine(time + "\n" + cCount);
        }

        static void InOut_Air()
        {
            for (int i = 0; i < n[0]; i++)
                isOut[i] = isOut[i].Select(x => x = false).ToArray();

            Queue<(int, int)> q = new Queue<(int, int)>();
            q.Enqueue((0, 0));
            isOut[0][0] = true;

            while (q.Count > 0)
            {
                var p = q.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int x = p.Item1 + ud[i];
                    int y = p.Item2 + lr[i];
                    if (x >= 0 && y >= 0 && x < n[0] && y < n[1] && cheese[x][y] == 0 && !isOut[x][y])
                    {
                        q.Enqueue((x, y));
                        isOut[x][y] = true;
                    }
                }
            }
        }

        static bool Timer()
        {
            CheeseCount();

            Queue<(int, int)> q = new Queue<(int, int)>();

            for (int i = 1; i < n[0] - 1; i++)
            {
                for (int j = 1; j < n[1] - 1; j++)
                {
                    if (cheese[i][j] == 1 && CheckOutsideCheese(i, j))
                        q.Enqueue((i, j));
                }
            }

            if (q.Count == 0)
                return false;

            while (q.Count > 0)
            {
                var p = q.Dequeue();
                cheese[p.Item1][p.Item2] = 0;
            }

            time++;

            return true;
        }

        static bool CheckOutsideCheese(int x, int y)
        {

            for (int i = 0; i < 4; i++)
            {
                int xx = x + ud[i];
                int yy = y + lr[i];

                if (isOut[xx][yy])
                    return true;
            }

            return false;
        }

        static void CheeseCount()
        {
            int cheeseC = 0;
            for (int i = 1; i < n[0] - 1; i++)
            {
                for (int j = 1; j < n[1] - 1; j++)
                    if (cheese[i][j] == 1)
                        cheeseC++;
            }

            cheeseCount.Add(cheeseC);
        }
    }
}
