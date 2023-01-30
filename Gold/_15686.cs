using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _15686
    {
        static int[] nm;
        static List<(int, int)> housePos = new();
        static List<(int, int)> chickenPos = new();
        static List<(int, int)> surviveChicken = new();
        static bool[] visited = new bool[13];
        static int ans = 50*50*13;

        static void Main(string[] args)
        {
            nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for(int i = 0; i< nm[0]; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j = 0; j < nm[0]; j++)
                {
                    if (arr[j] == 1)
                        housePos.Add((i, j));
                    else if (arr[j] == 2)
                        chickenPos.Add((i, j));
                }
            }

            ChickenBattle(0, 0);
            Console.WriteLine(ans);
        }

        static void ChickenBattle(int idx, int count)
        {
            if (count == nm[1])
                ChickenDist();

            for(int i = idx; i<chickenPos.Count; i++)
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    surviveChicken.Add((chickenPos[i].Item1, chickenPos[i].Item2));
                    ChickenBattle(i, count + 1);
                    surviveChicken.RemoveAt(surviveChicken.Count-1);
                    visited[i] = false;
                }
            }

        }

        static void ChickenDist()
        {
            int sum = 0;
            for(int i = 0; i<housePos.Count; i++)
            {
                int dist = 50* 50 * 13;
                for(int j = 0; j<nm[1]; j++)
                    dist = Math.Min(dist, Math.Abs(housePos[i].Item1 - surviveChicken[j].Item1) + Math.Abs(housePos[i].Item2 - surviveChicken[j].Item2));
                sum += dist;
            }

            ans = Math.Min(ans, sum);
        }
    }
}
