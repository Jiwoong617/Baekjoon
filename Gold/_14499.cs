using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _14499
    {
        static int[] dice = new int[6];

        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[][] map = new int[n[0]][];
            for (int i = 0; i < n[0]; i++)
                map[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] oper = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int x = n[2];
            int y = n[3];
            for(int i= 0; i < n[4]; i++)
            {
                int k = oper[i];
                int x2 = x;
                int y2 = y;

                if (k == 1) y2++;
                else if (k == 2) y2--;
                else if (k == 3) x2--;
                else x2++;

                if (x2 < 0 || x2 >= n[0] || y2 < 0 || y2 >= n[1])
                    continue;

                CalDir(k);
                x = x2; y = y2;
                if (map[x][y] == 0)
                    map[x][y] = dice[5];
                else
                {
                    dice[5] = map[x][y];
                    map[x][y] = 0;
                }

                stb.AppendLine(dice[0].ToString());
            }

            Console.WriteLine(stb);
        }

        static void CalDir(int dir)
        {
            int[] diceClone = (int[])dice.Clone();
            if(dir == 1)
                dice = new int[] { diceClone[3], diceClone[1], diceClone[0], diceClone[5], diceClone[4], diceClone[2] };
            else if (dir == 2)
                dice = new int[] { diceClone[2], diceClone[1], diceClone[5], diceClone[0], diceClone[4], diceClone[3] };
            else if (dir == 3)
                dice = new int[] { diceClone[4], diceClone[0], diceClone[2], diceClone[3], diceClone[5], diceClone[1] };
            else
                dice = new int[] { diceClone[1], diceClone[5], diceClone[2], diceClone[3], diceClone[0], diceClone[4] };
        }
    }
}
