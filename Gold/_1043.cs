using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _1043
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] know = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            bool[] find = new bool[n[1]];
            int[][] party = new int[n[1]][];
            for(int i = 0; i< n[1]; i++)
                party[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (know[0] == 0)
            {
                Console.WriteLine(n[1]);
                return;
            }

            List<int> knower = new List<int>();
            for(int i = 1; i < know.Length; i++)
                knower.Add(know[i]-1);

            for(int i = n[1]-1; i>=0; i--)
            {
                for(int j = 1; j < party[i].Length; j++)
                {
                    if (knower.Contains(party[i][j] - 1))
                    {
                        find[i] = true;
                        break;
                    }
                }

                if (find[i])
                {
                    for (int j = 1; j < party[i].Length; j++)
                        if (!knower.Contains(party[i][j] - 1))
                            knower.Add(party[i][j] - 1);
                }

                for(int j = 0; j < n[1]; j++)
                {
                    for(int k = 1; k < party[j].Length; k++)
                    {
                        if (knower.Contains(party[j][k] - 1))
                        {
                            find[j] = true;
                            break;
                        }
                    }
                    if (find[j])
                    {
                        for (int k = 1; k < party[j].Length; k++)
                            if (!knower.Contains(party[j][k] - 1))
                                knower.Add(party[j][k] - 1);
                    }
                }
            }

            Console.WriteLine(find.Count(x => x == false));
        }
    }
}
