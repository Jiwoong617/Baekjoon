using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _14503
    {
        static int[] n;
        static int[] loc; // 0-n 1-e 2-s 3-w
        static int[][] room;
        static int clean_count = 0;

        static int[] ud = { -1, 1, 0, 0 };
        static int[] lr = { 0, 0, -1, 1 };

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            loc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            room = new int[n[0]][];
            for(int i = 0; i< n[0]; i++)
                room[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Clean();

            Console.WriteLine(clean_count);
        }

        static void Clean()
        {
            while(true)
            {
                if (room[loc[0]][loc[1]] == 0)
                {
                    room[loc[0]][loc[1]] = 2;
                    clean_count++;
                }


                if (CheckOper())
                {
                    if (SecondOrder())
                        continue;
                    else
                        break;
                }
                else
                    ThirdOrder();
            }
        }

        static bool CheckOper()
        {
            bool flag = true;
            for(int i = 0; i<4; i++)
            {
                int x = loc[0] + ud[i];
                int y = loc[1] + lr[i];
                if(x>=0 && x < n[0] && y>=0 && y < n[1])
                {
                    if (room[x][y] == 0)
                    {
                        flag = false;
                        break;
                    }
                }
            }

            return flag ? true : false; // 2, 3
        }

        static bool SecondOrder()
        {
            switch (loc[2])
            {
                case 0:
                    if (loc[0]+1 < n[0]-1 && room[loc[0] + 1][loc[1]] != 1)
                    {
                        loc[0]++;
                        return true;
                    }
                    break;
                case 1:
                    if (loc[1]-1 > 0 && room[loc[0]][loc[1]-1] != 1)
                    {
                        loc[1]--;
                        return true;
                    }
                    break;
                case 2:
                    if (loc[0] - 1 > 0 && room[loc[0]-1][loc[1]] != 1)
                    {
                        loc[0]--;
                        return true;
                    }
                    break;
                case 3:
                    if (loc[1] + 1 < n[1] - 1 && room[loc[0]][loc[1]+1] != 1)
                    {
                        loc[1]++;
                        return true;
                    }
                    break;
            }

            return false;
        }

        static void ThirdOrder()
        {
            loc[2] = loc[2] - 1 == -1 ? 4 : loc[2] - 1;

            switch (loc[2])
            {
                case 0:
                    if (loc[0] -1 > 0 && room[loc[0] - 1][loc[1]] ==0)
                        loc[0]--;
                    break;
                case 1:
                    if (loc[1] + 1 <n[1]-1 && room[loc[0]][loc[1] + 1] == 0)
                        loc[1]++;
                    break;
                case 2:
                    if (loc[0] + 1 <n[0]-1 && room[loc[0] + 1][loc[1]] == 0)
                        loc[0]++;
                    break;
                case 3:
                    if (loc[1] - 1 > 0 && room[loc[0]][loc[1] - 1] == 0)
                        loc[1]--;
                    break;
            }
        }
    }
}
